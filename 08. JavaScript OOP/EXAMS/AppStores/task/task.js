function solve() {
    const validate = {
        appNameStringIsValid: function(str) {
            if (typeof str !== 'string') {
                return false;
            }
            // if (str.length < 1 || str.length > 24) {   // Now handled by the regexp
            //    return false;
            //}
            if (!str.match(/^[A-Za-z0-9 ]{1,24}$/)) {
                return false;
            }
            return true;
        },
        hostNameStringIsValid: function(str) {
            if (typeof str !== 'string') {
                return false;
            }
            if (str.length < 1 || str.length > 32) {

                return false;
            }

            return true;
        },
        deviceAppsAreValid: function(arr) {
            if(!arr.hasOwnProperty('length')) {
                return false;
            }

            let allAreApps = true;
            arr.forEach(a => {
                if(!validate.appNameStringIsValid(a.name)) {
                    allAreApps = false;
                }
            });

            return true;
        },
        appDescriptionStringIsValid: function(str) {
            if (typeof str !== 'string') {
                return false;
            }
            return true;
        },
        appVersionIsValid: function(num) {
            if (typeof num !== 'number') {
                return false;
            }
            if (num < 1) {
                return false;
            }
            return true;
        },
        appRatingIsValid: function(num) {
            if (typeof num !== 'number') {
                return false;
            }
            if (num < 1 || num > 10) {
                return false;
            }
            return true;
        },
        appReleaseVersionIsValid: function(current, incoming) {
            if (current > incoming) {
                return false;
            }
            return true;
        },
        appIsInstanceOfApp: function(app) {
            if (typeof app !== 'object') {
                return false;
            }
            if (!app.hasOwnProperty('name') ||
                !app.hasOwnProperty('description') ||
                !app.hasOwnProperty('version') ||
                !app.hasOwnProperty('rating')) {
                return false;
            }
            return true;
        }
    };

    function* idGen() {
        let currentId = 0;

        while(true) {
            currentId += 1;
            yield currentId;
        }
    };
    const idGenerator = idGen();

    const app = (function(parent) {
        let closure = Object.create(parent, {
            name: {
                get: function() {
                    return this._name;
                },
                set: function(name) {
                    if (!validate.appNameStringIsValid(name)) {
                        throw Error('Invalid App name string');
                    }
                    this._name = name;
                }
            },
            description: {
                get: function() {
                    return this._description;
                },
                set: function(desc) {
                    if (!validate.appDescriptionStringIsValid(desc)) {
                        throw Error('Invalid App description string');
                    }
                    this._description = desc;
                }
            },
            version: {
                get: function() {
                    return this._version;
                },
                set: function(ver) {
                    if (!validate.appVersionIsValid(ver)) {
                        throw Error('Invalid App version number');
                    }
                    this._version = ver;
                }
            },
            rating: {
                get: function() {
                    return this._rating;
                },
                set: function(rating) {
                    if (!validate.appRatingIsValid(rating)) {
                        throw Error('Invalid App rating number');
                    }
                    this._rating = rating;
                }
            }
        });

        closure.init = function(name, description, version, rating) {
            this.name = name;
            this.description = description;
            this.version = version;
            this.rating = rating;
            this._id = idGenerator.next().value;

            return this;
        };

        closure.release = function(obj) {
            if (typeof obj === 'number') {
                if (!validate.appReleaseVersionIsValid(this.version, obj)) {
                    throw Error('New version is older than existing');
                }
                this.version = obj;
            }
            if (typeof obj === 'object') {
                if (!obj.version ||
                    !validate.appVersionIsValid(obj.version) ||
                    !validate.appReleaseVersionIsValid(this.version, obj.version)) {
                    throw Error('Invalid new version provided');
                }
                // Optional description
                if (obj.hasOwnProperty('_description')) {
                    if (!validate.appDescriptionStringIsValid(obj.description)) {
                        throw Error('Invalid desc provided for update version');
                    }
                    this.description = obj.description;
                }
                // Optional rating
                if (obj.hasOwnProperty('_rating')) {
                    if (!validate.appRatingIsValid(obj.rating)) {
                        throw Error('Invalid rating provided for update version');
                    }
                    this.rating = obj.rating;
                }

                this.version = obj.version;
            }
        };

        return closure;
    }({}));

    const store = (function(parent) {
        let closure = Object.create(parent);

        closure.init = function(name, description, version, rating) {
            parent.init.call(this, name, description, version, rating);
            this._apps = [];
            return this;
        };

        closure.uploadApp = function(app) {
            if (!validate.appIsInstanceOfApp(app)) {
                throw Error ('Provided argument was not an instance of app');
            }
            let incomingApp = Object.create(parent).init(app.name,
                                                         app.description,
                                                         app.version,
                                                         app.rating);

            let incomingAppIndex = this._apps.findIndex(a => a.name === app.name);
            if (incomingAppIndex < 0) {
                this._apps.push(incomingApp);
            }
            if (incomingAppIndex >= 0) {
                this._apps[incomingAppIndex].release(incomingApp);
            }
            return this;
        };

        closure.takedownApp = function(name) {
            if (!validate.appNameStringIsValid(name)) {
                throw Error ('Provided name is invalid');
            }

            let incomingAppIndex = this._apps.findIndex(a => a.name === name );
            if (incomingAppIndex < 0) {
                throw Error ('App with the given name does not exist');
            }

            this._apps.splice(incomingAppIndex, 1);
            return this;
        };

        closure.search = function(pattern) {
            let matchedApps = [];
            pattern = pattern.toLowerCase();
            let re = new RegExp(pattern);

            for (let i of this._apps) {
                if (i.name.toLowerCase().match(re)) {
                    matchedApps.push(i);
                }
            }
            return matchedApps;
        };

        closure.listMostRecentApps = function(count) {
            count = count || 10;
            let allApps = this._apps.slice();
            let recentApps = allApps.sort((a, b) => {
                return a._id < b._id ? 1 : -1;
            });

            recentApps = recentApps.slice(0, count);

            return recentApps;
        };

        closure.listMostPopularApps = function(count) {
            count = count || 10;
            let allApps = this._apps.slice();
            let popularApps = allApps.sort((a, b) => {
                return a._rating < b._rating ? 1 : -1;
            });

            popularApps = popularApps.slice(0, count);

            return popularApps;
        };

        return closure;
    }(app));

    const device = (function(parent) {
        let closure = Object.create(parent, {
            hostname: {
                get: function() {
                    return this._hostname;
                },
                set: function(str) {
                    if(!validate.hostNameStringIsValid(str)) {
                        throw Error ('Invalid string provided for hostname');
                    }

                    this._hostname = str;
                }
            },
            apps: {
                get: function() {
                    return this._apps;
                },
                set: function(arr) {
                    if(!validate.deviceAppsAreValid(arr)) {
                        throw Error('Invalid apps array');
                    }
                    this._apps = arr;
                }
            }
        });

        closure.init = function(hostname, apps) {
            this.hostname = hostname;
            this.apps = apps;

            return this;
        };

        return closure;
    }({}));

    return {
        createApp(name, description, version, rating) {
            return Object.create(app)
                .init(name, description, version, rating);
        },
        createStore(name, description, version, rating) {
            return Object.create(store)
                .init(name, description, version, rating);
        },
        createDevice(hostname, apps) {
            return Object.create(device)
                .init(hostname, apps);
        }
    };
}

// Submit the code above this line in bgcoder.com
module.exports = solve;

let ns = solve();

let myApp = ns.createApp("Pokemon", "Time Waster", 1.12, 4.8);

//console.log(ns.validate.appNameStringIsValid("A valid string"));
//myApp.release(myUpdObj);
//console.log(myApp);

let myStore = ns.createStore("DeoStore", "Such store", 1, 4);
myStore.uploadApp({ name: "Contra", description: "Old timer", version: 1.4, rating: 1 })
    .uploadApp({ name: "SimCity", description: "City builder", version: 1.2, rating: 3.4 })
    .uploadApp({ name: "Contra", description: "Updated", version: 3, rating: 3.7 })
    .uploadApp({ name: "Fallout", description: "Role-playing", version: 1, rating: 4.9 })
    .uploadApp({ name: "Sonic", description: "Jump&Run", version: 2, rating: 2.9 });

//myStore.takedownApp("SimCity");

//let searchResult = myStore.search("City");
//console.log(searchResult);

//let recentApps = myStore.listMostRecentApps(2);
//console.log(recentApps);

//let popularApps = myStore.listMostPopularApps(2);
//console.log(popularApps);

let devApp1 = ns.createApp("Chromium", "A browser", 4.3, 4.5);
let devApp2 = ns.createApp("Soundcloud", "Music player", 3.9, 3.2);
let devApp3 = ns.createApp("emacs", "Text editor", 4.3, 4.5);

let myDevice = ns.createDevice("DeoDevice",
                               [devApp1, devApp2, devApp3,
                                { name: "Flightradar24", description: "Air traffic app", version: 3.2, rating: 2.1 } ]);
console.log(myDevice);

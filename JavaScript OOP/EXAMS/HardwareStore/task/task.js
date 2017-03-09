function solve() {
    function validateString1to20(str) {
        if (typeof str !== 'string' ||
            str.length < 1 ||
            str.length > 20) {
            throw Error('Invalid string');
        }
    }

    function validateString1to10(str) {
        if (typeof str !== 'string' ||
            str.length < 1 ||
            str.length > 10) {
            throw Error('Invalid string');
        }
    }

    function validatePositiveNumber(num) {
        if (typeof num !== 'number' ||
            Number.isNaN(num) ||
            num <= 0) {
            throw Error('Number should be positive');
        }
    }

    function validatePositiveIntegerNumber(num) {
        if (isNaN(num)) {
            throw Error('Number is required');
        }
        if (num <= 0) {
            throw Error('Number should be positive');
        }
        if (num !== parseInt(num, 10)) {
            throw Error('Number should be an integer');
        }
    }

    function validateVoltage(voltage) {
        if (typeof voltage !== 'number' ||
            Number.isNaN(voltage) ||
            voltage < 5 ||
            voltage > 20) {
            throw Error('Invalid voltage');
        }
    }

    function validateCurrent(current) {
        if (typeof current !== 'number' ||
            Number.isNaN(current) ||
            current < 100 ||
            current > 3000) {
            throw Error('Invalid current');
        }
    }

    function validateQuality(str) {
        if (typeof str !== 'string' ||
            !str.match(/^(high|mid|low)$/)) {
            throw Error('Invalid string provided for quality');
        }
    }

    function validateProduct(prod) {
        if (!prod instanceof Product) {
            throw Error('Invalid product');
        }
    }

    function* idGen() {
        let currentId = 0;

        while (true) {
            currentId += 1;
            yield currentId;
        }
    };
    const idGenerator = idGen();

    class Product {
        constructor(manufacturer, model, price) {
            validateString1to20(manufacturer);
            validateString1to20(model);
            validatePositiveNumber(price);

            this._manufacturer = manufacturer;
            this._model = model;
            this._price = price;
            this._id = idGenerator.next().value;
        }

        get manufacturer() {
            return this._manufacturer;
        }
        get model() {
            return this._model;
        }
        get price() {
            return this._price;
        }
        get id() {
            return this._id;
        }

        getLabel() {
            let product = this.constructor.name;
            let label = product + ' - ' + this.manufacturer + ' ' +
                this.model + ' - **' + this.price + '**';

            return label;
        }
    }

    class SmartPhone extends Product {
        constructor(manufacturer, model, price, screenSize, operatingSystem) {
            super(manufacturer, model, price);

            validatePositiveNumber(screenSize);
            validateString1to10(operatingSystem);

            this._screenSize = screenSize;
            this._operatingSystem = operatingSystem;
        }

        get screenSize() {
            return this._screenSize;
        }
        get operatingSystem() {
            return this._operatingSystem;
        }

        getLabel() {
            return super.getLabel();
        }
    }

    class Charger extends Product {
        constructor(manufacturer, model, price, outputVoltage, outputCurrent) {
            super(manufacturer, model, price);

            validateVoltage(outputVoltage);
            validateCurrent(outputCurrent);

            this._outputVoltage = outputVoltage;
            this._outputCurrent = outputCurrent;
        }

        get outputVoltage() {
            return this._outputVoltage;
        }
        get outputCurrent() {
            return this._outputCurrent;
        }

        getLabel() {
            return super.getLabel();
        }
    }

    class Router extends Product {
        constructor(manufacturer, model, price, wifiRange, lanPorts) {
            super(manufacturer, model, price);

            validatePositiveNumber(wifiRange);
            validatePositiveIntegerNumber(lanPorts);

            this._wifiRange = wifiRange;
            this._lanPorts = lanPorts;
        }

        get wifiRange() {
            return this._wifiRange;
        }
        get lanPorts() {
            return this._lanPorts;
        }

        getLabel() {
            return super.getLabel();
        }
    }

    class Headphones extends Product {
        constructor(manufacturer, model, price, quality, hasMicrophone) {
            super(manufacturer, model, price);

            validateQuality(quality);

            this._quality = quality;
            this._hasMicrophone = !!hasMicrophone;
        }

        get quality() {
            return this._quality;
        }
        get hasMicrophone() {
            return this._hasMicrophone;
        }

        getLabel() {
            return super.getLabel();
        }
    }

    class HardwareStore {
        constructor(name) {
            validateString1to20(name);

            this._name = name;
            this._products = [];
            this._stock = [];
            this._profits = 0;
        }

        get name() {
            return this._name;
        }
        get products() {
            return this._products;
        }

        stock(product, quantity) {
            validateProduct(product);
            validatePositiveIntegerNumber(quantity);

            let inventory = {
                product: product,
                quantity: quantity
            };

            let prodIndex = this._products.findIndex(p => {
                if (p.product.model === product.model &&
                    p.product.manufacturer === product.manufacturer &&
                    p.product.price === product.price) {
                    return true;
                }
                return false;
            });

            if (prodIndex >= 0) {
                this._products[prodIndex].quantity += quantity;
            } else {
                this._products.push(inventory);
            }
            return this;
        }

        sell(productId, quantity) {
            validatePositiveIntegerNumber(quantity);

            let index = this._products.findIndex(x => x.product.id === productId);

            if (index < 0) {
                throw Error('No such productId to sell');
            }
            if (this._products[index].quantity < quantity) {
                throw Error('Not enough inventory to sell');
            }

            let profitAmount = this._products[index].product.price * quantity;
            this._profits += profitAmount;
            this._products[index].quantity -= quantity;

            if (this._products[index].quantity === 0) {
                this._products.splice(index, 1);
            }

            return this;
        }

        getSold() {
            return this._profits;
        }

        search(pattern) {
            let results = [];

            if (typeof pattern === 'string') {
                pattern = pattern.toLowerCase();

                this._products.forEach(p => {
                    let resultProduct = {};
                    if (p.product._model.toLowerCase().indexOf(pattern) < 0 &&
                        p.product._manufacturer.toLowerCase().indexOf(pattern) < 0) {
                        return;
                    }
                    resultProduct['product'] = p.product;
                    resultProduct['quantity'] = p.quantity;

                    results.push(resultProduct);
                });
            }
            if (typeof pattern === 'object') {
                // Start with all products in inventory
                results = this._products.slice();
                if (pattern.hasOwnProperty('type')) {
                    results = results.filter(p => p.product.constructor.name === pattern.type);
                }
                if (pattern.hasOwnProperty('manufacturerPattern')) {
                    results = results.filter(p => p.product._manufacturer.indexOf(pattern.manufacturerPattern) >= 0);
                }
                if (pattern.hasOwnProperty('modelPattern')) {
                    results = results.filter(p => p.product._model.indexOf(pattern.modelPattern) >= 0);
                }
                if (pattern.hasOwnProperty('minPrice')) {
                    results = results.filter(p => p.product._price >= pattern.minPrice);
                }
                if (pattern.hasOwnProperty('maxPrice')) {
                    results = results.filter(p => p.product._price <= pattern.maxPrice);
                }
            }
            return results;
        }
    }

    return {
        getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
            return new SmartPhone(manufacturer, model, price, screenSize, operatingSystem);
        },
        getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
            return new Charger(manufacturer, model, price, outputVoltage, outputCurrent);
        },
        getRouter(manufacturer, model, price, wifiRange, lanPorts) {
            return new Router(manufacturer, model, price, wifiRange, lanPorts);
        },
        getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
            return new Headphones(manufacturer, model, price, quality, hasMicrophone);
        },
        getHardwareStore(name) {
            return new HardwareStore(name);
        }
    };
}


module.exports = solve;
// Tests

const result = solve();
// Test all product types
const phone = result.getSmartPhone('HTC', 'One', 903, 5, 'Android');
const phone2 = result.getSmartPhone('Samsung', 'A330', 1093, 5, 'Android');
//console.log(phone.getLabel()); 

const charger = result.getCharger('Samsung', 'bsc', 10, 12, 1500);
const charger2 = result.getCharger('Alba', 'cool', 13, 12, 1000);
//console.log(charger.getLabel());

const router = result.getRouter('TP_Link', 'AWZ0101', 122, 100, 8);
//console.log(router.getLabel());

const headphones = result.getHeadphones('Sennheiser', 'PXC 550 Wireless', 340, 'high', false);
//console.log(headphones.getLabel());

// Test the store
const store = result.getHardwareStore('Magazin');

store.stock(phone, 1)
    .stock(phone2, 2)
    .stock(headphones, 15)
    .stock(charger, 7)
    .stock(charger2, 3)
    .stock(router, 5);

// When stocked with a product that is already present, increase its quantity
store.stock(phone, 2);
//console.log(store);

// When selling items, decrease the quantity. If the quantity is 0, delete the product
store.sell(headphones.id, 5);
store.sell(charger2.id, 3);
//console.log(store);

// Check if the profits are correctly returned
//console.log(store.getSold());

// Check if searching with string yields correct results
//console.log(store.search('senn'));
/*
  [ { product:
  Headphones { ... },
  quantity: 15 } ]
*/

// Check if searching with patterns yields correct results
const basicPhone = {
    type: 'SmartPhone'
};
//console.log(store.search(basicPhone));

const basicManufacturer = {
    manufacturerPattern: 'Samsung'
};
//console.log(store.search(basicManufacturer));

const basicModel = {
    modelPattern: 'AWZ0101'
};
//console.log(store.search(basicModel));

const basicMinPrice = {
    minPrice: 1000
};
//console.log(store.search(basicMinPrice));

const basicMaxPrice = {
    maxPrice: 1000
};
//console.log(store.search(basicMaxPrice));

const combinedTypePrice = {
    type: 'SmartPhone',
    maxPrice: 900
};
//console.log(store.search(combinedTypePrice));

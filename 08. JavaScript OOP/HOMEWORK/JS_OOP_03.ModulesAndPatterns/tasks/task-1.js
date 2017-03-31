// somehow got the points, but is incomplete... to be reworked
function solve() {

    var Course = (function() {
        function init(title, presentations) {
            this.students = [];
            this.presentations = [];
            this.homeworks = [];
            currPresentationID = 1;

            if (!isValidTitle(title)) {
                throw "Invalid title name";
            }
            this.title = title;

            if (!arePresentationsValid(presentations)) {
                throw "Invalid presentations array";
            }
            presentations.forEach(p => this.presentations.push({
                title: p,
                id: currPresentationID++
                }
            ));

            return this;
        };


        function arePresentationsValid(presentations) {
            let isValid = (!!presentations.length &&
                           presentations.every(t => isValidTitle(t)));
            return isValid;
        };

        function isValidTitle(string) {
            const regexTestsTitle = [/^$/, // Check for empty string
                /^\s+/, // Check for whitespace-front
                /\s\s+/, // Check for multiple whitespaces
                /\s+$/ // check for whitespace-end
            ];
            let isValid = regexTestsTitle.some(t => t.test(string)) ? false : true;
            return isValid;
        };

        function addStudent(string) {
            newStudent = new student();
            newStudent.init(string);
            this.students.push(newStudent);
            return newStudent.id;
        };

        function getAllStudents() {
            let result = [];
            this.students.forEach(s => {result.push(
                {id: s.id,
                 firstname: s.firstName,
                 lastname: s.lastName}
            );});
            return result;
        };

        function submitHomework(studentID, homeworkID) {
            if (!studentID ||
                studentID <= 0 ||
                !this.students.some(s => s.id === studentID)) {
                throw "Invalid Student ID provided";
            }
            if (!isValidHomeworkID(homeworkID)) {
                throw "Invalid Homework ID provided";
            }
            if (!this.presentations.some(p => p.id === homeworkID)) {
                throw "Homework ID not matching presentation schema";
            }
            this.homeworks.push({sID: studentID, hwID: homeworkID});
        };

        function isValidHomeworkID(homeworkID) {
            if (!homeworkID || isNaN(homeworkID)) {
                return false;
            }
            if (homeworkID <= 0) {
                return false;
            }
            if (homeworkID !== parseInt(homeworkID, 10)) {
                return false;
            }
            return true;
        };

        function pushExamResults(results) {
            // ***
            //results.forEach(r => {console.log({stID: r.StudentID, res: r.score});});
            console.log(this.students);
            console.log(results);
            if (!results || !results.hasOwnProperty(StudentID)) {
                throw "no results";
            }



        };

        function getTopStudents() {};

        return {
            init: init,
            addStudent: addStudent,
            submitHomework: submitHomework,
            getAllStudents: getAllStudents,
            pushExamResults: pushExamResults,
            getTopStudents: getTopStudents
        };
    })();

    // Student Revealing Module Pattern
    var student = function() {

        var idTracker = 0;
        var idGenerator = (function() {
            return {
                getUniqueId: function() {
                    idTracker += 1;
                    return idTracker;
                }
            };
        })();

        var init = function(name) {
            if (!isValidName(name)) {
                throw "Invalid student name";
            }
            let fullName = name.split(' ');

            this.firstName = fullName[0];
            this.lastName = fullName[1];
            this.id = idGenerator.getUniqueId();
        };

        var isValidName = function(string) {
            const regexTestsName = /^[A-Z][a-z]*\s[A-Z][a-z]*$/g;
            let isValid = (string && regexTestsName.test(string));
            return isValid;
        };

        return {
            "init": init,
            "firstName": this.firstName,
            "lastName": this.lastName,
            "id": this.id
        };
    };

    return Course;
}

module.exports = solve;

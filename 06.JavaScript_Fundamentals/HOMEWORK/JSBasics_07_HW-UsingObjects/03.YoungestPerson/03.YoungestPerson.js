function solveProblem(args) {
    var input = args;
    var people = [];

    // Create a person constructor
    function constructPerson(firstName, lastName, age) {
        return {
            firstname: firstName,
            lastname: lastName,
            age: parseInt(age)
        };
    }

    // Create a function to compare age for a given array of Person objects
    function getYoungest(people) {
        var youngestPerson = people[0];
        for (var i = 1; i < people.length; i += 1) {
            if (people[i].age < youngestPerson.age) {
                youngestPerson = people[i];
            }
        }
        return youngestPerson;
    }

    // Construct an array of Person objects for an unknown input size
    while(input.length > 0) {
        var person = constructPerson.apply(this, (input.slice(0, 3)));
        people.push(person);
        input.splice(0, 3);
    }

    youngestPerson = getYoungest(people);
    console.log(youngestPerson.firstname + ' ' + youngestPerson.lastname);

}


// TESTS

var test1 = [
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
];
solveProblem(test1);

var test2 = [
    'Penka', 'Hristova', '61',
    'System', 'Failiure', '88',
    'Bat', 'Man', '16',
    'Malko', 'Kote', '72'
];
    solveProblem(test2);

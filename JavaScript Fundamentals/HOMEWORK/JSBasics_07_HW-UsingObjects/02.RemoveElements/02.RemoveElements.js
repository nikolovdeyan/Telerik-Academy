function solveProblem(args) {

    var inputArr = args;

    Array.prototype.removeMember = function(numToRemove) {
        var index = this.indexOf(numToRemove);
        while(index > -1) {
            this.splice(index, 1);
            index = this.indexOf(numToRemove);
        }
        return this;
    };

    result = inputArr.removeMember(inputArr[0]).join('\n');
    console.log(result);
}


// TESTS

var test1 = [ '1', '2', '3', '2', '1', '2', '3', '2' ];
solveProblem(test1);

var test2 = [
    '_h/_',
    '^54F#',
    'V',
    '^54F#',
    'Z285',
    'kv?tc`',
    '^54F#',
    '_h/_',
    'Z285',
    '_h/_',
    'kv?tc`',
    'Z285',
    '^54F#',
    'Z285',
    'Z285',
    '_h/_',
    '^54F#',
    'kv?tc`',
    'kv?tc`',
    'Z285'];
solveProblem(test2);

var test3 = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
solveProblem(test3);

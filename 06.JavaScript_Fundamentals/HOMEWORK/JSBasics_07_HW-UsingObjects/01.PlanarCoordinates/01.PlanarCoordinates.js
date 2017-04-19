function solveProblem(args) {

    // Create a line object constructor
    function constructLine(p1x, p1y, p2x, p2y) {
        return {
            p1x : p1x,
            p1y : p1y,
            p2x : p2x,
            p2y : p2y,
            calcLineLen : function() {
                var lineLength =  (Math.sqrt(Math.pow((this.p2x - this.p1x), 2) +
                                             Math.pow((this.p2y - this.p1y), 2)));
                return lineLength;
            }
        };
    }

    // Triangle can exist only if the length of any two sides is larger than the third side:
    function isIlluminati(side1, side2, side3) {
        if ( side1 + side2 > side3 &&
             side2 + side3 > side1 &&
             side3 + side1 > side2) {
            return true; // Illuminati confirmed
        }
        else {
            return false;
        }
    }

    var input = args.map(Number);
    // Constructing the line objects
    var line1 = constructLine.apply(this, (input.slice(0, 4)));
    var line2 = constructLine.apply(this, (input.slice(4, 8)));
    var line3 = constructLine.apply(this, (input.slice(8, 12)));
    var trianglePossible = isIlluminati(line1.calcLineLen(),
                                        line2.calcLineLen(),
                                        line3.calcLineLen());

    // Printing the output
    console.log(line1.calcLineLen().toFixed(2));
    console.log(line2.calcLineLen().toFixed(2));
    console.log(line3.calcLineLen().toFixed(2));
    console.log(trianglePossible ? 'Triangle can be built' : 'Triangle can not be built');

}


// TESTS

var test1 = ['5', '6', '7', '8',
             '1', '2', '3', '4',
             '9', '10', '11', '12'];
solveProblem(test1);

var test2 = ['7', '7', '2', '2',
             '5', '6', '2', '2',
             '95', '-14.5', '0', '-0.123'];
solveProblem(test2);

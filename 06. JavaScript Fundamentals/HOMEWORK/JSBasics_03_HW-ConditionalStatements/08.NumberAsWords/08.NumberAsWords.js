
function solveProblem(args) {
    var n = args[0];
    var result = '';

    // Making it a three digit number (as a string)
    n = ('00' + n).slice(-3);
    nHundreds = parseInt(n[0], 10);
    nTens = parseInt(n[1], 10);
    nOnes = parseInt(n[2], 10);
    oneToTwenty = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten',
                   'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen',
                   'eighteen', 'nineteen'];
    tensToHundred = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

    // Check if in the hundreds first
    if (nHundreds > 0) {
        result = oneToTwenty[nHundreds] + ' hundred and ';
    }

    // Check if last two digits are in the range 0-20
    if (nTens < 2) {
        var i = parseInt(nTens.toString() + nOnes.toString(), 10);
        result = result + oneToTwenty[i];
    }
    else {
        result = result + tensToHundred[nTens] + ' ' + oneToTwenty[nOnes];
    }

    // Capitalize the first letter only
    result = result.charAt(0).toUpperCase() + result.slice(1);

    // In the special cases 20, 30, 40 <-> 220, 230, 240 etc.
    // we make an additional check for trailing 'zero' / 'and zero'
    result = result.replace('and zero', '').replace(' zero', '');

    console.log(result);
}

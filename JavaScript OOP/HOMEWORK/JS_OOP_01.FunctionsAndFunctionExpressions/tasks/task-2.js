/* Task Description */
/* 
	 Write a function that sums an array of numbers:
	 numbers must be always of type Number
	 returns `null` if the array is empty
	 throws Error if the parameter is not passed (undefined)
	 throws if any of the elements is not convertible to Number	
*/
function solve() {
	return function sum(rangeFrom, rangeTo) {

    let result = [];

    // Helper function
    let isPrime = function(num) {
        if(num <= 1) { return false; }
        for (let i = 2; i < num; i += 1) {
            if (num % i === 0) {
					return false;
				}
			}
			return true;
		};

		// Check for invalid arguments first
		if (typeof(rangeFrom) === 'undefined' || typeof(rangeTo) === 'undefined') {
			throw {
				name: 'MissingArgumentError',
				message: 'The function primeNumbers accepts exactly two arguments.'
			};
		}

		if (isNaN(rangeFrom) || isNaN(rangeTo)) {
			throw {	
				name: 'InvalidArgumentError',
				message: 'Both function parameters should be numbers.'
			};
		}

		for (let i = +rangeFrom; i <= +rangeTo; i += 1) {
			if (isPrime(i)) {
				result.push(i);
			}
		}
		return result;
	}
}

module.exports = sum;

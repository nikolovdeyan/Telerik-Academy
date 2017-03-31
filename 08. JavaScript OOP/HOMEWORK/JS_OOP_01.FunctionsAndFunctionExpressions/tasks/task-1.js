/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
	return function sumArray(numArr) {
		let result = 0;

		// First check for missing arguments
		if (typeof(numArr) === 'undefined') {
			throw {
				name: 'NullArgumentError',
				message: 'No argument provided.'
			};
		}

		// Now check for empty array
		if (numArr.length === 0) {
			return null;
		}

		// Now sum the elements, checking if they are of type number
		for (let i = 0; i < numArr.length; i += 1) {
			if (isNaN(numArr[i])) {
				throw {
					name: 'InvalidArgumentError',
					message: 'All array elements should be of number type'
				};
			}
	
			result += +numArr[i];
		}
		return result;
	}
}

module.exports = sumArray;


const {createPhoneNumber} = require("./training/CreatePhoneNumber");
const {fibonacci} = require("./training/memo_fib")
const {numberJoy} = require("./training/HarshadTest")

console.log('Code wars kata for js')


// console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
// console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
// console.log(createPhoneNumber([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]));
// console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
// console.log(fibonacci(6));  // 8
// console.log(fibonacci(7));  // 13
// console.log(fibonacci(8)); // 21
// console.log(fibonacci(50));  // 12586269025
console.log(numberJoy(1997))  // false
console.log(numberJoy(1998))  // false, 'Harshad but digit sum=27, and 27x72 does not equal 1998')
console.log(numberJoy(1729)) // true, 'Harshad and digit sum=19, and 19x91 = 1729')
console.log(numberJoy(18))  // false, 'Harshad but digit sum=9, and 9x9 does not equal 18')
console.log(numberJoy(1))  // true, "It was correct")
console.log(numberJoy(81))// true, "It was correct")
console.log(numberJoy(1458))  // true, "It was correct")

console.log('Done.')
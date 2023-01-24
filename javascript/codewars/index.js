const {createPhoneNumber} = require("./training/CreatePhoneNumber");
const {fibonacci} = require("./training/memo_fib")

console.log('Code wars kata for js')


console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
console.log(createPhoneNumber([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]));
console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
console.log(fibonacci(6));  // 8
console.log(fibonacci(7));  // 13
console.log(fibonacci(8)); // 21
console.log(fibonacci(50));  // 12586269025


console.log('Done.')
//Write an algorithm that takes an array and moves all of the zeros to the end, preserving
// the order of the other elements.
//
// moveZeros([false,1,0,1,2,0,1,3,"a"]) // returns[false,1,1,2,1,3,"a",0,0]

function moveZeros(arr) {
    return arr.filter(x => x !== 0).concat(arr.filter(x => x === 0));
}

console.log(moveZeros([1, 0, 1, 2, 0, 1, 3]))  // [1, 1, 2, 1, 3, 0, 0]
console.log(moveZeros([0, 1, 0, 2, 0, 1, 3]))  // [1, 2, 1, 3, 0, 0, 0]
console.log(moveZeros([0, 0, 0, 0, 0, 0, 0]))  // [0, 0, 0, 0, 0, 0, 0]
console.log(moveZeros([1, 2, 3, 4, 5, 6, 7]))  // [1, 2, 3, 4, 5, 6, 7]
console.log(moveZeros([0, 0, 0, 0, 0, 0, 1]))  // [1, 0, 0, 0, 0, 0, 0]
console.log(moveZeros([0, 0, 0, 0, 0, 1, 0]))  // [1, 0, 0, 0, 0, 0, 0]
console.log(moveZeros([0, 0, 0, 0, 1, 0, 0]))  // [1, 0, 0, 0, 0, 0, 0]
console.log(moveZeros([0, 0, 0, 1, 0, 0, 0]))  // [1, 0, 0, 0, 0, 0, 0]
console.log(moveZeros([0, 0, 1, 0, 0, 0, 0]))  // [1, 0, 0, 0, 0, 0, 0]
console.log(moveZeros([0, 1, 0, 0, 0, 0, 0]))  // [1, 0, 0, 0, 0, 0, 0]

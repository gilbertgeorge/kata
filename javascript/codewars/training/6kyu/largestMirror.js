// We'll think that a "mirror" section in an array is a group of contiguous elements ( > 1) such that somewhere in the
// array, the same group appears in reverse order. For example, the largest mirror section in [1, 2, 3, 8, 9, 3, 2, 1]
// is length 3 (the ...1, 2, 3... part). Return the length of the largest mirror section in the given array.
//
// If the mirror doesn't exist or array is empty, return 0.

const maxMirror = (array) => {
    let max = 0;
    for(let i = 0; i < array.length; i++){
        let count = 0;
        for(let j = array.length - 1, k = i, h = j; j > i; k++, h-- ){
            if(array[k] === array[h] && k < array.length && h > -1){
                count ++
            } else {
                max = Math.max(max, count);
                count = 0;
                j --;
                k = i - 1;
                h = j + 1;
            }
        }
    }
    if (max === 1) {
        max = 0;
    }
    return max;
}

console.log(maxMirror([1, 2, 3, 8, 9, 3, 2, 1, 9, 8]));  // 3
console.log(maxMirror([1, 2, 2, 1]));  // 4
console.log(maxMirror([1, 2, 1, 4]));  // 3
console.log(maxMirror([7, 1, 2, 9, 7, 2, 1]));  // 2
console.log(maxMirror([1, 2, 3, 6, 7, 3, 2, 1, 5]));  // 3
console.log(maxMirror([1, 2, 2]));  // 2
console.log(maxMirror([1, 2, 3]));  // 0
console.log(maxMirror([1, 5]));  // 0
console.log(maxMirror([1]));  // 0
console.log(maxMirror([]));  // 0
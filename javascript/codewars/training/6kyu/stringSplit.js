// Complete the solution so that it splits the string into pairs of two characters.
// If the string contains an odd number of characters then it should replace
// the missing second character of the final pair with an underscore ('_').
//
//     Examples:
//
// * 'abc' =>  ['ab', 'c_']
// * 'abcdef' => ['ab', 'cd', 'ef']

function solution(str){
    let myArray = [];
    let matches = str.match(/.{2}/g);
    if (matches) {
        myArray = matches;
    }
    if (str.length % 2 !== 0) {
        myArray.push(str.slice(-1) + '_');
    }
    return myArray;
}

console.log(solution('abc'));  // ['ab', 'c_']
console.log(solution('abcdef'));  // ['ab', 'cd', 'ef']
console.log(solution('abcdefg'));  // ['ab', 'cd', 'ef', 'g_']
console.log(solution(''));  // []
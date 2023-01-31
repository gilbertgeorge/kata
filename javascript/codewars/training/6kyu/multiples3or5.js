// If we list all the natural numbers below 10 that are multiples of 3 or 5,
// we get 3, 5, 6 and 9. The sum of these multiples is 23.
//
// Finish the solution so that it returns the sum of all the multiples of
// 3 or 5 below the number passed in. Additionally, if the number is negative,
// return 0 (for languages that do have them).
//
// Note: If the number is a multiple of both 3 and 5, only count it once.

function solution(number){
    return number < 0 ? 0 : Array.from({length: number}, (v, i) => i)
        .filter(x => x % 3 === 0 || x % 5 === 0)
        .reduce((acc, cur) => acc + cur, 0);
}

console.log(solution(0))
console.log(solution(10))
console.log(solution(20))
console.log(solution(200))
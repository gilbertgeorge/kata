// If we list all the natural numbers below 10 that are multiples of 3 or 5,
// we get 3, 5, 6 and 9. The sum of these multiples is 23.
//
// Finish the solution so that it returns the sum of all the multiples of 3 or 5
// below the number passed in. Additionally, if the number is negative, return 0
// (for languages that do have them).
//
// Note: If the number is a multiple of both 3 and 5, only count it once.


export class Challenge {
    static solution(number: number) {
        return Array.from({length: number}, (v, i) => i)
            .filter(n => n % 3 === 0 || n % 5 === 0)
            .reduce((sum, a) => sum + a, 0);
    }
}

import {assert} from "chai";

function test(num: number, expected: number) {
    assert.strictEqual(Challenge.solution(num), expected)
}

describe("solution", function(){
    it("should handle basic tests", function() {
        test(0, 0);
        test(10, 23);
        test(20, 78);
        test(200, 9168);
    });
});
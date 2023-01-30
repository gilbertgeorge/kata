// Create a function that takes an integer as an argument and returns "Even"
// for even numbers or "Odd" for odd numbers.

export function even_or_odd(n:number):string {
    return n % 2 === 0 ? "Even" : "Odd";
}

import {assert} from "chai";

describe("solution", function(){
    it("basicTests", function(){
        assert.equal(even_or_odd(2), "Even");
        assert.equal(even_or_odd(0), "Even");
        assert.equal(even_or_odd(7), "Odd");
        assert.equal(even_or_odd(1), "Odd");
        assert.equal(even_or_odd(-4), "Even");
        assert.equal(even_or_odd(-3), "Odd");
    });
});
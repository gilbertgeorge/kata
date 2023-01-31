export function orderWeight(weights: string): string {
    let list = weights.split(" ").filter(s => s.length > 0);
    return list.sort((a, b) => {
        let sumA = a.split("").reduce((sum, digit) => sum + parseInt(digit), 0)
        let sumB = b.split("").reduce((sum, digit) => sum + parseInt(digit), 0)
        if (sumA === sumB) {
            return a.toString() > b.toString() ? 1 : -1
        }
        return sumA > sumB ? 1 : -1
    }).join(" ");
}

import { assert } from "chai";

describe("Fixed Tests", function() {
    it("orderWeight", function() {
        assert.strictEqual(orderWeight("56 65 74 100 99 68 86 180 90"), "100 180 90 56 65 74 68 86 99");
        assert.strictEqual(orderWeight("103 123 4444 99 2000"), "2000 103 123 4444 99");
        assert.strictEqual(orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"), "11 11 2000 10003 22 123 1234000 44444444 9999");
        assert.strictEqual(orderWeight("  2000  10003   1234000 44444444 9999 11 11 22 123"), "11 11 2000 10003 22 123 1234000 44444444 9999");
    });
});

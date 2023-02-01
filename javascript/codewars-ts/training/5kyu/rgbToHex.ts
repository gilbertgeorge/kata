// The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
//
// Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
//
// The following are examples of expected output values:
//
// rgb(255, 255, 255) // returns FFFFFF
// rgb(255, 255, 300) // returns FFFFFF
// rgb(0,0,0) // returns 000000
// rgb(148, 0, 211) // returns 9400D3

export function rgb(r: number, g: number, b: number): string {
    const hex = (n: number) => {
        n = Math.max(0, Math.min(n, 255));
        return n.toString(16).padStart(2, "0").toUpperCase();
    }
    return hex(r) + hex(g) + hex(b);
}

import { assert } from "chai"


describe("Tests", function () {
    it("Basic Tests", function () {
        assert.strictEqual(rgb(0, 0, 0), "000000")
        assert.strictEqual(rgb(0, 0, -20), "000000")
        assert.strictEqual(rgb(300, 255, 255), "FFFFFF")
        assert.strictEqual(rgb(173, 255, 47), "ADFF2F")
    })
})
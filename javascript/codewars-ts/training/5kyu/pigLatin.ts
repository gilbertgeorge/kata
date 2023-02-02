export const pigIt = (a : string) : string =>  {
    return a.replace(/\w+/g, (match) => match.slice(1) + match[0] + 'ay');
}


import { assert } from "chai";

describe("Tests", () => {
    it("test", () => {
        assert.strictEqual(pigIt('Pig latin is cool'),'igPay atinlay siay oolcay')
        assert.strictEqual(pigIt('This is my string'),'hisTay siay ymay tringsay')
    });
});

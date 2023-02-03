const alphabet = 'abcdefghijklmnopqrstuvwxyz'.split('');

export const mix = (s1:string, s2:string): string =>{
    return alphabet
        .map(char => {
            const s1Count = s1.split('').filter(x => x === char).length,
                s2Count = s2.split('').filter(x => x === char).length,
                maxCount = Math.max(s1Count, s2Count);

            return {
                char: char,
                count: maxCount,
                src: maxCount > s1Count ? '2' : maxCount > s2Count ? '1' : '='
            };
        })
        .filter(c => c.count > 1)
        .sort((objA, objB) => objB.count - objA.count || (objA.src + objA.char > objB.src + objB.char ? 1 : -1))
        .map(c => `${c.src}:${c.char.repeat(c.count)}`)
        .join('/');
}


import {assert} from "chai";

function testing(s1:string, s2:string, expected:string) {
    assert.strictEqual(mix(s1, s2), expected);
}

describe("Fixed Tests", function() {
    it("mix", function() {
        testing("Are they here", "yes, they are here", "2:eeeee/2:yy/=:hh/=:rr");
        testing("looping is fun but dangerous", "less dangerous than coding", "1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg");
        testing(" In many languages", " there's a pair of functions", "1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt");
    });
});

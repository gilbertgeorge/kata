export function createPhoneNumber(numbers: number[]): string {
    return '(' + numbers.slice(0,3).join('') + ') '
        + numbers.slice(3,6).join('')
        + '-'
        + numbers.slice(6).join('');
}

import { assert } from "chai";

describe('Tests', () => {
    it('Should pass sample tests', () => {
        assert.equal(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]), "(123) 456-7890");
        assert.equal(createPhoneNumber([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]), "(111) 111-1111");
        assert.equal(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]), "(123) 456-7890");
    });
});
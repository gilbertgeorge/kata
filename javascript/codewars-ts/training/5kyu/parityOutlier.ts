// You are given an array (which will have a length of at least 3, but could be very large)
// containing integers. The array is either entirely comprised of odd integers or entirely
// comprised of even integers except for a single integer N. Write a method that takes the
// array as an argument and returns this "outlier" N.

export function findOutlier(integers: number[]): number {
    if(integers.filter(n => n % 2 === 0).length > 1) {
        let odd = integers.find(n => n % 2 !== 0);
        return odd ? odd : 0;
    }
    else {
        let even = integers.find(n => n % 2 === 0);
        return even ? even : 0;
    }
}

import { assert } from 'chai';


it('Simple tests', function() {
    assert.equal(findOutlier([0, 1, 2]), 1);
    assert.equal(findOutlier([1, 2, 3]), 2);
    assert.equal(findOutlier([2, 6, 8, 10, 3]), 3);
    assert.equal(findOutlier([0, 0, 3, 0, 0]), 3);
    assert.equal(findOutlier([1, 1, 0, 1, 1]), 0);
    assert.equal(findOutlier([165091914,-147887996,-132272584,19684530,74234344,-26328216,-108333446,107321766,195444204,170431178,173979617,11059310,-53756848,-10147876,-72010686,-85097628,76834234,57879894,-111545222,186785432,-160949458,65583048,-136879226,-31050352,35842316,198919918,21150488,-123184050,-33927640,152109134]), 173979617);
});
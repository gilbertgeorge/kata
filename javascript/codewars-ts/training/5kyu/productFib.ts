type fibonacciMemo = {[key: number]: number};

function fibonacci(n: number, memo: fibonacciMemo) : fibonacciMemo {
    if(n===0) return memo[1] ? memo : Object.assign(memo, {0: 0});
    if(n<=1) return memo[1] ? memo : Object.assign(memo, {1: 1});
    if(memo[n]) return memo;
    memo[n] = fibonacci(n-1, memo)[n-1] + fibonacci(n-2, memo)[n-2];
    return memo;
}

export const productFib = (prod:number): [number,number,boolean] => {
    let i = 0;
    let memo: fibonacciMemo = {};
    while(fibonacci(i, memo)[i] * fibonacci(i+1, memo)[i+1] < prod){
        i++;
    }
    return [fibonacci(i, memo)[i], fibonacci(i+1, memo)[i+1],
        fibonacci(i, memo)[i] * fibonacci(i+1, memo)[i+1]===prod];
}

import chai, {assert} from "chai";
chai.config.truncateThreshold = 0;

function dotest(prod:number, expected:[number,number,boolean]) {
    assert.deepEqual(productFib(prod), expected);
}

describe("Fixed Tests", function() {
    it("productFib", function() {
        dotest(4895, [55, 89, true])
        dotest(5895, [89, 144, false])
        dotest(74049690, [6765, 10946, true])
        dotest(84049690, [10946, 17711, false])
        dotest(193864606, [10946, 17711, true])
        dotest(447577, [610, 987, false])
        dotest(602070, [610, 987, true])
    });
});

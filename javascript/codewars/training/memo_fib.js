function fibonacci(n, memo ={}){
    if(n===0) return 0;
    if(n<=1) return 1;
    if(memo[n]) return memo[n];
    memo[n] = fibonacci(n-1, memo)+fibonacci(n-2, memo);
    return memo[n];
}


module.exports.fibonacci = fibonacci;
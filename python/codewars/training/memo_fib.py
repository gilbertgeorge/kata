# Fibonacci with memoization

def fibonacci(n, memo=None):
    if memo is None:
        memo = {}
    if n in memo:
        return memo[n]
    if n <= 2:
        return 1
    memo[n] = fibonacci(n - 1, memo) + fibonacci(n - 2, memo)
    return memo[n]


if __name__ == '__main__':
    print(fibonacci(0))
    print(fibonacci(1))
    print(fibonacci(1))
    print(fibonacci(6))  # 8
    print(fibonacci(7))  # 13
    print(fibonacci(8))  # 21
    print(fibonacci(50))  # 12586269025
    # print(fibonacci(10000))  # 12586269025

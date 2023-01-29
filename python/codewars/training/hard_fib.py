def fib(n):
    is_negative = False
    if n < 0:
        n = abs(n)
        if n % 2 == 0:
            is_negative = True
    if n == 0:
        return 0
    v1, v2, v3 = 1, 1, 0
    for rec in bin(n)[3:]:
        calc = v2*v2
        v1, v2, v3 = v1*v1+calc, (v1+v3)*v2, calc+v3*v3
        if rec == '1':
            v1, v2, v3 = v1+v2, v1, v2
    return v2 if not is_negative else -v2


if __name__ == '__main__':
    print(fib(0))  # 0
    print(fib(1))  # 1
    print(fib(2))  # 1
    print(fib(3))  # 2
    print(fib(4))  # 3
    print(fib(5))  # 5
    print(fib(6))  # 8
    print(fib(7))  # 13
    print(fib(8))  # 21
    print(fib(-6))  # -8
    print(fib(-60))  # -1548008755920
    print(fib(-96))  # -51680708854858323072
    print(fib(-17))  # 1597
    print(fib(-37))  # 24157817
    print(fib(-79))  # 14472334024676221
    print(fib(1000))
    print(fib(1462631))

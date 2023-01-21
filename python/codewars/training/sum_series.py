def get_sum(a, b):
    if a == b:
        return a
    else:
        result = 0
        low = a if a < b else b
        high = b if b > a else a
        for value in range(low, high + 1):
            result += value
        return result


if __name__ == '__main__':
    print(get_sum(0, 1))
    print(get_sum(0, -1))
    print(get_sum(1, 2))
    print(get_sum(5, -5))
    print(get_sum(10, 5))

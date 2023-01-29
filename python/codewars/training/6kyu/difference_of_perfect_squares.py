# This kata will return a string that represents the difference of
# two perfect squares as the sum of consecutive odd numbers.
#
# Specifications:
#
# • The first input minus the second input reveals the exact number of consecutive odd numbers required
#   for the solution - you can check this in the examples below.
# • The first input will always be larger than the second.
# • All inputs will be valid so no need for error checking.
# • Outputs will always be positive.
# • Inputs will range between 0 and 200, (inclusive).
# • In the returned string there are spaces before and after the plus sign, the minus
#   sign and the equals sign but nowhere else.

def consecutive_odd_sum(total, size):
    odd_list = list(filter(lambda x: x % 2 != 0, range(1, total + 1)))
    for index, num in enumerate(odd_list):
        if sum(odd_list[index:index + size]) == total:
            return ' + '.join([str(i) for i in odd_list[index:index + size]])
    return total


def squares_to_odd(a, b):
    total = a ** 2 - b ** 2
    return f'{a}^2 - {b}^2 = {consecutive_odd_sum(total, a - b)} = {total}'


if __name__ == '__main__':
    print(squares_to_odd(9, 5))  # "9^2 - 5^2 = 11 + 13 + 15 + 17 = 56"
    print(squares_to_odd(10, 7))  # "10^2 - 7^2 = 15 + 17 + 19 = 51"
    print(squares_to_odd(100, 98))  # "100^2 - 98^2 = 197 + 199 = 396"
    print(squares_to_odd(100, 99))  # "100^2 - 99^2 = 199 = 199"

    # print(consecutive_odd_sum(56, 4))  # 11 + 13 + 15 + 17
    # print(consecutive_odd_sum(51, 3))  # 15 + 17 + 19
    # print(consecutive_odd_sum(396, 2))  # 197 + 199
    # print(consecutive_odd_sum(199, 1))  # 199

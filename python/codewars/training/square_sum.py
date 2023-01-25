# Complete the square sum function so that it squares each number passed into
# it and then sums the results together.
#
# For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.


def square_sum(numbers):
    return sum([number ** 2 for number in numbers])


if __name__ == '__main__':
    print(square_sum([1, 2]))  # 5
    print(square_sum([0, 3, 4, 5]))  # 50
    print(square_sum([]))  # 0
    print(square_sum([-1, -2]))  # 5
    print(square_sum([-1, 0, 1]))  # 2

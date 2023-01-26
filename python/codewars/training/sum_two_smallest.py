# Create a function that returns the sum of the two lowest positive numbers given an array
# of minimum 4 positive integers. No floats or non-positive integers will be passed.
#
# For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
#
# [10, 343445353, 3453445, 3453545353453] should return 3453455.


def sum_two_smallest_numbers(numbers):
    return sum(sorted(numbers)[:2])


if __name__ == '__main__':
    print(sum_two_smallest_numbers([5, 8, 12, 19, 22]))  # 13
    print(sum_two_smallest_numbers([15, 28, 4, 2, 43]))  # 6
    print(sum_two_smallest_numbers([3, 87, 45, 12, 7]))  # 10
    print(sum_two_smallest_numbers([23, 71, 33, 82, 1]))  # 24
    print(sum_two_smallest_numbers([52, 76, 14, 12, 4]))  # 16

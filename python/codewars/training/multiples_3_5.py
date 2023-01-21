# If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
# The sum of these multiples is 23.
#
# Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
# Additionally, if the number is negative, return 0 (for languages that do have them).
#
# Note: If the number is a multiple of both 3 and 5, only count it once.


def solution(number):
    result = 0
    if number > 0:
        for value in range(1, number):
            if value % 3 == 0 or value % 5 == 0:
                result += value
    return result


if __name__ == '__main__':
    print(solution(10))
    print(solution(20))
    print(solution(200))

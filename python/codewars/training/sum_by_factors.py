# DESCRIPTION:
# Given an array of positive or negative integers
#
#  I= [i1,..,in]
#
# you have to produce a sorted array P of the form
#
# [ [p, sum of all ij of I for which p is a prime factor (p positive) of ij] ...]
#
# P will be sorted by increasing order of the prime numbers. The final result has to be
# given as a string in Java, C#, C, C++ and as an array of arrays in other languages.
#
# Example:
# I = [12, 15] # result = [[2, 12], [3, 27], [5, 15]]
# [2, 3, 5] is the list of all prime factors of the elements of I, hence the result.
#
# Notes:
#
# It can happen that a sum is 0 if some numbers are negative!
# Example: I = [15, 30, -45] 5 divides 15, 30 and (-45) so 5 appears in the result, the sum of
# the numbers for which 5 is a factor is 0 so we have [5, 0] in the result amongst others.
#
# In Fortran - as in any other language - the returned string is not permitted to contain any
# redundant trailing whitespace: you can use dynamically allocated character strings.

# ******************* Not working for very large numbers *******************
# ********************** Need to revisit this solution *********************
def prime_factors(num):
    factors = set()
    while num % 2 == 0:
        factors.add(2)
        num //= 2
    for i in range(3, int(abs(num) ** 0.5) + 1, 2):
        while num % i == 0:
            factors.add(i)
            num //= i
    if num > 2:
        factors.add(num)
    return factors


def sum_for_list(lst):
    factors = set()
    for num in lst:
        factors.update(prime_factors(num))
    result = []
    for factor in sorted(factors):
        result.append([factor, sum([num for num in lst if num % factor == 0])])
    return result


if __name__ == '__main__':
    print(sum_for_list([12, 15]))  # [[2, 12], [3, 27], [5, 15]]
    print(sum_for_list([15, 21, 24, 30, 45]))  # [[2, 54], [3, 135], [5, 90], [7, 21]]
    print(sum_for_list([15, 30, -45]))  # [[2, 30], [3, 0], [5, 0]]
    print(sum_for_list([15, 21, 24, 30, -45]))  # [[2, 54], [3, 45], [5, 0], [7, 21]]
    print(sum_for_list([107, 158, 204, 100, 118, 123, 126, 110, 116, 100]))  # [[2, 1032], [3, 453], [5, 310], [7, 126], [11, 110], [17, 204], [29, 116], [41, 82], [59, 118], [79, 158], [107, 107]]

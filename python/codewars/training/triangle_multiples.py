#  See the following triangle:
#
# ____________________________________
#  1
#  2   4   2
#  3   6   9   6   3
#  4   8   12  16  12  8   4
#  5   10  15  20  25  20  15  10  5
#  ___________________________________
#
# The total sum of the numbers in the triangle, up to the 5th line included, is 225, part of it, 144, corresponds
# to the total sum of the even terms and 81 to the total sum of the odd terms.
#
# Create a function that may output an array with three results for each value of n.
#
# triang_mult(n)  ----> [total_sum, total_even_sum, total_odd_sum]
# Our example will be:
#
# triang_mult(5) ----> [225, 144, 81]
# Features of the random tests:
#
# number of tests = 100
# 49 < n < 5000


# def mult_triangle(n):
#     row_size = 2 * n - 1
#     row = [(lambda x: x * n if x <= n else (row_size - x + 1) * n)(x) for x in range(1, row_size + 1)]
#     row_sum = [sum(row), sum([x for x in row if x % 2 == 0]), sum([x for x in row if x % 2 != 0])]
#     if n == 1:
#         return row_sum
#     else:
#         prior_row = mult_triangle(n - 1)
#         return [row_sum[x] + prior_row[x] for x in range(len(row_sum))]


# def generate_row(n):
#     row_size = 2 * n - 1
#     return [(lambda x: x * n if x <= n else (row_size - x + 1) * n)(x) for x in range(1, row_size + 1)]


def generate_row(n):
    row = [x * n for x in range(1, n + 1)]
    return row + row[-2::-1]


def mult_triangle(n):
    total_sum = [0, 0, 0]
    while n > 0:
        row = generate_row(n)
        for x in row:
            if x % 2 == 0:
                total_sum[1] += x
            else:
                total_sum[2] += x
        # total_sum[0] += sum(row)
        n -= 1
    total_sum[0] = total_sum[1] + total_sum[2]
    return total_sum


if __name__ == '__main__':
    print(mult_triangle(1), [1, 0, 1])
    print(mult_triangle(2), [9, 8, 1])
    print(mult_triangle(3), [36, 20, 16])
    print(mult_triangle(4), [100, 84, 16])
    print(mult_triangle(5), [225, 144, 81])
    print(mult_triangle(6))
    print(mult_triangle(7))
    print()
    # print(mult_triangle(5000))
    print(generate_row(1))
    print(generate_row(2))
    print(generate_row(3))
    print(generate_row(4))
    print(generate_row(5))
    print(generate_row(6))
    print(generate_row(7))
    # print(generate_row_reflection(1))
    # print(generate_row_reflection(2))
    # print(generate_row_reflection(3))
    # print(generate_row_reflection(4))
    # print(generate_row_reflection(5))
    # print(generate_row_reflection(6))




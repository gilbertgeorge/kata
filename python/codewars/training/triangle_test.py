# Implement a function that accepts 3 integer values a, b, c. The function should return true
# if a triangle can be built with the sides of given length and false in any other case.
#
# (In this case, all triangles must have surface greater than 0 to be accepted).

def is_triangle(a, b, c):
    if a > 0 and b > 0 and c > 0:
        if a + b > c and a + c > b and b + c > a:
            return True
        else:
            return False
    return False


if __name__ == '__main__':
    print(is_triangle(1, 2, 2))
    print(is_triangle(7, 2, 2))
    print(is_triangle(1, 2, 3))
    print(is_triangle(1, 3, 2))
    print(is_triangle(3, 1, 2))
    print(is_triangle(5, 1, 2))
    print(is_triangle(1, 2, 5))
    print(is_triangle(2, 5, 1))
    print(is_triangle(4, 2, 3))
    print(is_triangle(5, 1, 5))
    print(is_triangle(2, 2, 2))
    print(is_triangle(-1, 2, 3))
    print(is_triangle(1, -2, 3))
    print(is_triangle(1, 2, -3))
    print(is_triangle(0, 2, 3))

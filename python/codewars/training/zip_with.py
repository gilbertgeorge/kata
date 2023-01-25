# zip_with takes a function and two arrays and zips the arrays together, applying the function to every pair of values.
# The function value is one new array.
#
# If the arrays are of unequal length, the output will only be as long as the shorter one.
# (Values of the longer array are simply not used.)
#
# Inputs should not be modified.
#
# Examples
# zip_with( pow, [10,10,10,10], [0,1,2,3] )     =>  [1,10,100,1000]
# zip_with( max, [1,4,7,1,4,7], [4,7,1,4,7,1])  =>  [4,7,7,4,7,7]
#
# def add(a,b): return a+b; # or from operator import add
# zip_with( add,             [0,1,2,3], [0,1,2,3] )  =>  [0,2,4,6]  # Both forms are valid
# zip_with( lambda a,b: a+b, [0,1,2,3], [0,1,2,3] )  =>  [0,2,4,6]  # Both are functions
from operator import sub, add, mul


def zip_with(fn, a1, a2):
    return [fn(a, b) for a, b in zip(a1, a2)]


if __name__ == '__main__':
    print(zip_with(add, [0, 1, 2, 3, 4, 5], [6, 5, 4, 3, 2, 1]))  # [6, 6, 6, 6, 6, 6]
    print(zip_with(add, [0, 1, 2, 3, 4], [6, 5, 4, 3, 2, 1]))  # [6, 6, 6, 6, 6]
    print(zip_with(add, [0, 1, 2, 3, 4, 5], [6, 5, 4, 3, 2]))  # [6, 6, 6, 6, 6]
    print(zip_with(pow, [10, 10, 10, 10], [0, 1, 2, 3]))  # [1, 10, 100, 1000]
    print(zip_with(max, [1, 4, 7, 1, 4, 7], [4, 7, 1, 4, 7, 1]))  # [4, 7, 7, 4, 7, 7]
    print(zip_with(add, [0, 1, 2, 3], [0, 1, 2, 3]))  # [0, 2, 4, 6]
    print(zip_with(add, [0, 1, 2, 3], [0, 1, 2, 3]))  # [0, 2, 4, 6])
    print(zip_with(pow, [10, 10, 10, 10, 10, 10, 10], [0, 1, 2, 3, 4, 5, 6]))  # [1e0, 1e1, 1e2, 1e3, 1e4, 1e5, 1e6]
    print(zip_with(sub, [0, 1, 2, 3, 4, 5], [6, 5, 4, 3, 2, 1]))  # [-6, -4, -2, 0, 2, 4]
    print(zip_with(mul, ["a", "b", "c", "d", "e", "f"], [6, 5, 4, 3, 2, 1]))  # ["aaaaaa", "bbbbb", "cccc", "ddd", "ee", "f"]

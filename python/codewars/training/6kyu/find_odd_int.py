# Given an array of integers, find the one that appears an odd number of times.
#
# There will always be only one integer that appears an odd number of times.

def find_it(seq):
    for x in seq:
        if seq.count(x) % 2 != 0:
            return x


if __name__ == '__main__':
    print(find_it([7]))  # 7
    print(find_it([0]))  # 0
    print(find_it([1, 1, 2]))  # 2
    print(find_it([0, 1, 0, 1, 0]))  # 0
    print(find_it([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]))  # 4
    print(find_it([1, 1, 2, 2, 3, 3, 4, 3, 3, 2, 2, 1, 1, 5, 5, 5, 5, 5]))  # 4
    print(find_it([20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5]))  # 5
    print(find_it([10]))  # 10
    print(find_it([1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1]))  # 10
    print(find_it([5, 4, 3, 2, 1, 5, 4, 3, 2, 10, 10]))  # 1

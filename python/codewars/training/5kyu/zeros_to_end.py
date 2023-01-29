# Write an algorithm that takes an array and moves all of the zeros to the end,
# preserving the order of the other elements.
#
# move_zeros([1, 0, 1, 2, 0, 1, 3]) # returns [1, 1, 2, 1, 3, 0, 0]


def move_zeros(lst):
    return [x for x in lst if x != 0] + [x for x in lst if x == 0]


if __name__ == '__main__':
    print(move_zeros([1, 0, 1, 2, 0, 1, 3]))  # [1, 1, 2, 1, 3, 0, 0]
    print(move_zeros([0, 1, 0, 2, 0, 1, 3]))  # [1, 2, 1, 3, 0, 0, 0]
    print(move_zeros([0, 0, 0, 0, 0, 0, 0]))  # [0, 0, 0, 0, 0, 0, 0]
    print(move_zeros([1, 2, 3, 4, 5, 6, 7]))  # [1, 2, 3, 4, 5, 6, 7]
    print(move_zeros([0, 0, 0, 0, 0, 0, 1]))  # [1, 0, 0, 0, 0, 0, 0]
    print(move_zeros([0, 0, 0, 0, 0, 1, 0]))  # [1, 0, 0, 0, 0, 0, 0]
    print(move_zeros([0, 0, 0, 0, 1, 0, 0]))  # [1, 0, 0, 0, 0, 0, 0]
    print(move_zeros([0, 0, 0, 1, 0, 0, 0]))  # [1, 0, 0, 0, 0, 0, 0]
    print(move_zeros([0, 0, 1, 0, 0, 0, 0]))  # [1, 0, 0, 0, 0, 0, 0]
    print(move_zeros([0, 1, 0, 0, 0, 0, 0]))  # [1, 0, 0, 0, 0, 0, 0]

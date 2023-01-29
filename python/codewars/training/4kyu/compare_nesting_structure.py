# Complete the function/method (depending on the language) to return true/True when its argument
# is an array that has the same nesting structures and same corresponding length of nested arrays as the first array.
#
# For example:
#
# # should return True
# same_structure_as([ 1, 1, 1 ], [ 2, 2, 2 ] )
# same_structure_as([ 1, [ 1, 1 ] ], [ 2, [ 2, 2 ] ] )
#
# # should return False
# same_structure_as([ 1, [ 1, 1 ] ], [ [ 2, 2 ], 2 ] )
# same_structure_as([ 1, [ 1, 1 ] ], [ [ 2 ], 2 ] )
#
# # should return True
# same_structure_as([ [ [ ], [ ] ] ], [ [ [ ], [ ] ] ] )
#
# # should return False
# same_structure_as([ [ [ ], [ ] ] ], [ [ 1, 1 ] ] )

def same_structure_as(original, other):
    if type(original) != type(other) and (type(original) == list or type(other) == list):
        return False
    if type(original) == list and type(other) == list:
        if len(original) != len(other):
            return False
        for i in range(len(original)):
            if not same_structure_as(original[i], other[i]):
                return False
    return True


if __name__ == '__main__':
    print(same_structure_as([1, 1, 1], [2, 2, 2]))  # True
    print(same_structure_as([1, [1, 1]], [2, [2, 2]]))  # True
    print(same_structure_as([1, [1, 1]], [[2, 2], 2]))  # False
    print(same_structure_as([1, [1, 1]], [[2], 2]))  # False
    print(same_structure_as([[[], []]], [[[], []]]))  # True
    print(same_structure_as([[[], []]], [[1, 1]]))  # False
    print(same_structure_as([1, '[', ']'], ['[', ']', 1]))  # True

# An infinite number of shelves are arranged one above the other in a staggered fashion.
# The cat can jump either one or three shelves at a time: from shelf i to shelf i+1 or
# i+3 (the cat cannot climb on the shelf directly above its head), according to the illustration:
#
#                  ┌────────┐
#                  │-6------│
#                  └────────┘
# ┌────────┐
# │------5-│
# └────────┘  ┌─────► OK!
#             │    ┌────────┐
#             │    │-4------│
#             │    └────────┘
# ┌────────┐  │
# │------3-│  │
# BANG!────┘  ├─────► OK!
#   ▲  |\_/|  │    ┌────────┐
#   │ ("^-^)  │    │-2------│
#   │ )   (   │    └────────┘
# ┌─┴─┴───┴┬──┘
# │------1-│
# └────────┘
#
# Input
# Start and finish shelf numbers (always positive integers, finish no smaller than start)
#
# Task
# Find the minimum number of jumps to go from start to finish
#
# Example
# Start 1, finish 5, then answer is 2 (1 => 4 => 5 or 1 => 2 => 5)

def solution(start, finish):
    steps = finish - start
    if steps % 3 == 0:
        return steps // 3
    elif steps % 3 == 1:
        return steps // 3 + 1
    else:
        return steps // 3 + 2


if __name__ == '__main__':
    print(solution(1, 5))  # 2
    print(solution(1, 3))  # 2
    print(solution(1, 4))  # 1
    print(solution(2, 4))  # 2


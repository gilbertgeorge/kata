# Clock shows h hours, m minutes and s seconds after midnight.
#
# Your task is to write a function which returns the time since midnight in milliseconds.

def past(h, m, s):
    return (h * 3600 + m * 60 + s) * 1000


if __name__ == '__main__':
    print(past(0, 1, 1))  # 61000
    print(past(1, 1, 1))  # 3661000
    print(past(0, 0, 0))  # 0
    print(past(1, 0, 1))  # 3601000
    print(past(1, 0, 0))  # 3600000

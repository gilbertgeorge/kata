# Digital root is the recursive sum of all the digits in a number.
#
# Given n, take the sum of the digits of n. If that value has more than one digit,
# continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

def digital_root(n):
    string_n = str(n)
    if len(string_n) > 1:
        return digital_root(sum(int(digit) for digit in string_n))
    else:
        return n


if __name__ == '__main__':
    print(digital_root(16))  # 7
    print(digital_root(942))  # 6
    print(digital_root(132189))  # 6
    print(digital_root(493193))  # 2

# Your task is to create a function that will take an integer and return the result of the
# look-and-say function on that integer. This should be a general function that takes as input
# any positive integer, and returns an integer; inputs are not limited to the sequence which starts with "1".
#
# Conway's Look-and-say sequence goes like this:
#
# Start with a number.
# Look at the number, and group consecutive digits together.
# For each digit group, say the number of digits, then the digit itself.
# This can be repeated on its result to generate the sequence.
#
# For example:
#
# Start with 1.
# There is one 1 --> 11
# Start with 11. There are two 1 digits --> 21
# Start with 21. There is one 2 and one 1 --> 1211
# Start with 1211. There is one 1, one 2, and two 1s --> 111221

def look_say(n):
    string_num = str(n)
    number_list = []
    position = -1
    for char in string_num:
        if len(number_list) == 0:
            number_list.append({"digit": char, "count": 1})
            position += 1
        elif char == number_list[position]["digit"]:
            number_list[position]["count"] += 1
        else:
            number_list.append({"digit": char, "count": 1})
            position += 1
    return int("".join(str(item["count"]) + item["digit"] for item in number_list))


if __name__ == '__main__':
    print(look_say(1))  # 11
    print(look_say(11))  # 21
    print(look_say(21))  # 1211
    print(look_say(22334455))  # 22232425
    print(look_say(1211))  # 111221

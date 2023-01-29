# Write a function that takes a string of parentheses, and determines if the order of the parentheses
# is valid. The function should return true if the string is valid, and false if it's invalid.
#
# Examples
# "()"              =>  true
# ")(()))"          =>  false
# "("               =>  false
# "(())((()())())"  =>  true
# Constraints
# 0 <= input.length <= 100
#
# Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters.
# Furthermore, the input string may be empty and/or not contain any parentheses at all. Do not treat
# other forms of brackets as parentheses (e.g. [], {}, <>).

def valid_parentheses(string):
    stack = []
    for char in string:
        if char == "(":
            stack.append(char)
        elif char == ")":
            if len(stack) == 0:
                return False
            stack.pop()
    if len(stack) > 0:
        return False
    return True


if __name__ == '__main__':
    print(valid_parentheses("  ("))  # False
    print(valid_parentheses(")test"))  # False
    print(valid_parentheses(""))  # True
    print(valid_parentheses("hi())("))  # False
    print(valid_parentheses("hi(hi)()"))  # True

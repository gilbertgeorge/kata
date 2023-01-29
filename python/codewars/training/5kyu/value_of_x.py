# Jack's teacher gave him a ton of equations for homework. The thing is they are all kind of same so they are boring.
#
# So help him by making a equation solving function that will return the value of x.
#
# Test Cases will be like this:
#
# # INPUT            # RETURN
# 'x + 1 = 9 - 2'    # 6
# '- 10 = x'         # -10
# 'x - 2 + 3 = 2'    # 1
# '- x = - 1'        # 1
# All test cases are valid.
# Every +, - and numbers will be separated by space.
# There will be only one x either on the left or right.
# x can have a - mark before it.
# returned object will be a integer.


def solve(eq):
    sides = eq.replace(' ', '').split('=')
    if 'x' in sides[1]:
        sides[0], sides[1] = sides[1], sides[0]
    if '-x' not in sides[0] and '-x' not in sides[1]:
        return eval(sides[1].replace('x', '0')) - eval(sides[0].replace('x', '0'))
    else:
        return eval(sides[0].replace('x', '0')) - eval(sides[1].replace('x', '0'))


if __name__ == '__main__':
    print(solve('x + 1 = 9 - 2'))  # 6
    print(solve('- 10 = x'))  # -10
    print(solve('x - 2 + 3 = 2'))  # 1
    print(solve('- x = - 1'))  # 1
    print(solve('- 1 = - x'))  # 1
    print(solve('x - 2 + 3 = 2'))  # 1
    print(solve('x = + 2 - 5 + 9'))  # 6
    print(solve('x - 0 + 0 = 0'))  # 0
    print()
    print(solve('- x - 1 = 8'))  # -9
    print(solve('- x - 2 = 9'))  # -11
    print(solve('- x = - 8 - 7'))  # 15
    print()
    print(solve('9 - 1 = - x + 10'))  # 2

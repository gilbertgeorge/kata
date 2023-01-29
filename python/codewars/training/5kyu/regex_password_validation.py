# You need to write regex that will validate a password to make sure it meets the following criteria:
#
# At least six characters long
# contains a lowercase letter
# contains an uppercase letter
# contains a digit
# only contains alphanumeric characters (note that '_' is not alphanumeric)
from re import search


def password_validate(password):
    result = search(r'^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$', password)
    if result:
        return True
    return False


if __name__ == '__main__':
    print(password_validate('fjd3IR9'))  # True
    print(password_validate('ghdfj32'))  # False
    print(password_validate('DSJKHD23'))  # False
    print(password_validate('dsF43'))  # False
    print(password_validate('4fdg5Fj3'))  # True
    print(password_validate('DHSJdhjsU'))  # False
    print(password_validate('fjd3IR9.;'))  # False
    print(password_validate('fjd3  IR9'))  # False
    print(password_validate('djI38D55'))  # True
    print(password_validate('a2.d412'))   # False
    print(password_validate('JHD5FJ53'))  # False
    print(password_validate('!fdjn345'))  # False
    print(password_validate('jfkdfj3j'))  # False
    print(password_validate('123'))  # False
    print(password_validate('abc'))  # False
    print(password_validate('123abcABC'))  # True
    print(password_validate('ABC123abc'))  # True
    print(password_validate('Password123'))  # True

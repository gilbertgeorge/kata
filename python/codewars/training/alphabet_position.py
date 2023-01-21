# In this kata you are required to, given a string, replace every letter with its position in the alphabet.
#
# If anything in the text isn't a letter, ignore it and don't return it.
#
# "a" = 1, "b" = 2, etc.

def alphabet_position(text):
    result = ''
    for letter in text:
        if letter.isalpha():
            position = ord(letter.lower()) - 96
            result = f'{result} {position}'
    return result.strip()


if __name__ == '__main__':
    print(alphabet_position("The sunset sets at twelve o' clock."))

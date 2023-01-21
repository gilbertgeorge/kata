def longest(a1, a2):
    result = set()
    for letter in a1 + a2:
        result.add(letter)
    return ''.join(sorted(result))


if __name__ == '__main__':
    print(longest("aretheyhere", "yestheyarehere"))
    print(longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"))
    print(longest("loopingisfunbutdangerous", "lessdangerousthancoding"))
    print(longest("inmanylanguages", "theresapairoffunctions"))

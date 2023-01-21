def maskify(cc):
    mask = cc
    if len(cc) > 4:
        mask = '#' * (len(cc) - 4) + cc[-4:]
    return mask


if __name__ == '__main__':
    print(maskify('4556364607935616'))
    print(maskify('64607935616'))
    print(maskify('1'))
    print(maskify(''))
    print(maskify('Skippy'))
    print(maskify('Nananananananananananananananana Batman!'))

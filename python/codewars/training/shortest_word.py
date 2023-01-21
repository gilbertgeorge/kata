def find_short(sentence):
    words = sentence.split()
    return min(len(word) for word in words)


if __name__ == '__main__':
    print(find_short("bitcoin take over the world maybe who knows perhaps"))
    print(find_short("turns out random test cases are easier than writing out basic ones"))

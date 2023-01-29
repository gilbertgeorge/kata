# You probably know the "like" system from Facebook and other pages. People can "like" blog posts,
# pictures or other items. We want to create the text that should be displayed next to such an item.
#
# Implement the function which takes an array containing the names of people that like an item.
# It must return the display text as shown in the examples:
#
# []                                -->  "no one likes this"
# ["Peter"]                         -->  "Peter likes this"
# ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
# ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
# ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
# Note: For 4 or more names, the number in "and 2 others" simply increases.
from itertools import chain, islice


def likes(names):
    if len(names) == 0:
        return f'no one likes this'
    elif len(names) == 1:
        return f'{names[0]} likes this'
    else:
        return f"{' and '.join([', '.join(names[:-1]), names[-1]] if len(names) < 4 else [', '.join(names[:2]), f'{len(names) - 2} others'])} like this"


if __name__ == '__main__':
    print(likes([]))  # no one likes this
    print(likes(['Peter']))  # Peter likes this
    print(likes(['Jacob', 'Alex']))  # Jacob and Alex like this
    print(likes(['Max', 'John', 'Mark']))  # Max, John and Mark like this
    print(likes(['Alex', 'Jacob', 'Mark', 'Max']))  # Alex, Jacob and 2 others like this

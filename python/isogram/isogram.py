import re

def is_isogram(string):
    normalize = re.sub(r'\W', '', string.lower())

    for c in normalize:
        if normalize.count(c) > 1:
            return False
    return True

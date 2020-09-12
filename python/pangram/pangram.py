def is_pangram(sentence):

    letters = 'abcdefghijklmnopqrstuvwxyz'

    for char in letters:
        if char not in sentence.lower():
            return False

    return True

import re
import string

def is_pangram(sentence):
    
    normalize = re.sub('[^a-z]', '', sentence.lower())

    letters = []
    for c in normalize:
        if c not in letters:
            letters.append(c)
            
    letters.sort()
    return ''.join(letters) == string.ascii_lowercase

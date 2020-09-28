import math

def is_armstrong_number(number):
    stringify = str(number)
    power = len(stringify)
    powers = []


    for base in stringify:
        value = int(math.pow(int(base), power))
        powers.append(value)
        
    return number == sum(powers)

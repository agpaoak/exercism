import math

def is_armstrong_number(number):
    num_list = list(map(int, str(number)))
    power = len(num_list)
    powers = [ int(math.pow(base, power)) for base in num_list ]
 
    return number == sum(powers)
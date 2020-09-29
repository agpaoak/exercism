import math


def classify(number):
    if number <= 0:
        raise ValueError('Values must be greater than 0')
    elif number == 1 or is_prime(number):
        return 'deficient'
    else:
        aliquot_num = aliquot_sum(number)
        if aliquot_num < number:
            return 'deficient'
        elif aliquot_num == number:
            return 'perfect'
        elif aliquot_num > number:
            return 'abundant'


def is_prime(number):
    factors = get_factors(number)
    return len(factors) == 2


def aliquot_sum(number):
    factors = get_factors(number)
    i = factors.index(number)
    factors.pop(i)
    return sum(factors)


def get_factors(number):
    factors = []
    n = 1
    while n**2 <= number:
        if number % n == 0 and n not in factors:
            factors.append(n)
            i = number//n
            if number % i == 0 and i not in factors:
                factors.append(i)
        n += 1
    return factors

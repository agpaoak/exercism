def convert(number):

    rValue = ''

    if (number%3 != 0 and
        number%5 != 0 and
        number%7 != 0):
        return str(number)

    if (number%3 == 0):
        rValue = rValue + 'Pling'
    if(number%5 == 0):
        rValue = rValue + 'Plang'
    if(number%7 == 0):
        rValue = rValue + 'Plong'

    return rValue

def convert(number):
    r_value = pling(number) + plang(number) + plong(number)

    return r_value if r_value else str(number)

    def pling(number):
        return 'Pling' if (number % 3 == 0) else  ''

    def plang(number):
        return 'Plang' if (number % 5 == 0) else  ''

    def plong(number):
        return 'Plong' if (number % 7 == 0) else  ''
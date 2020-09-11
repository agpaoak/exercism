class Matrix:
    def __init__(self, matrix_string):
        self.ms = matrix_string.split('\n')

    def row(self, index):
        return self.__convert_to_int(self.ms[index - 1].split())

    def column(self, index):

        c = []

        for row in self.ms:
            c.append(row.split()[index - 1])

        return self.__convert_to_int(c)

    def __convert_to_int(self, arr):
        return list(map(lambda x: int(x), arr))

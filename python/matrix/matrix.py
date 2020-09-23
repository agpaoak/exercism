class Matrix:
    def __init__(self, matrix_string):
        self.matrix = [arr.split(' ') for arr in matrix_string.split('\n')]

    def row(self, index):
        return [int(row) for row in self.matrix[index-1]]
    
    def column(self, index):
        return [int(row[index-1]) for row in self.matrix]
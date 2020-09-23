import secrets
import string

class Robot:

    names = []

    def __init__(self):
        self.name = None
        self.reset()

    def reset(self):
        self.name = self.get_name()
        Robot.names.append(self.name)
    
    def __get_rand_int(self):
        max_num = 999
        return str(secrets.randbelow(max_num + 1)).zfill(3)

    def __get_rand_char(self):
        letters = string.ascii_uppercase
        return secrets.choice(letters)

    def __create_name(self):
        return f'{self.__get_rand_char()}{self.__get_rand_char()}{self.__get_rand_int()}'

    def get_name(self):
     
        temp_name = self.__create_name()

        while temp_name in Robot.names:
            temp_name = self.__create_name()

        return temp_name


        string.asc
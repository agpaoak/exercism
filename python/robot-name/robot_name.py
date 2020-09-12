import random

class Robot:

    names = []

    def __init__(self):
        self.name = None
        self.reset()

    def reset(self):
        self.name = self.__get_name()
        self.names.append(self.name)

    def __get_rand_int(self):
        return str(random.randrange(0,999)).zfill(3)

    def __get_rand_char(self):
        letters ="abcdefghijklmnopqrstuvwxyz"

        return random.choice(letters.upper())

    def __get_name(self):
        temp_name = "{}{}{}".format(self.__get_rand_char(),self.__get_rand_char(), self.__get_rand_int())

        while temp_name not in self.names:
            temp_name = "{}{}{}".format(self.__get_rand_char(),self.__get_rand_char(), self.__get_rand_int())
        self.names.append(temp_name)

        return temp_name
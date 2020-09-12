import random

class Robot:

    names = []

    def __init__(self):
        self.name = None
        self.reset()

    def reset(self):
        self.name = self.get_name()
        Robot.names.append(self.name)
    
    def __get_rand_int(self):
        return str(random.randrange(0,999)).zfill(3)

    def __get_rand_char(self):
        letters ="abcdefghijklmnopqrstuvwxyz"
        return random.choice(letters.upper())

    def __create_name(self):
        return "{}{}{}".format(self.__get_rand_char(), self.__get_rand_char(), self.__get_rand_int())

    def get_name(self):
     
        temp_name = self.__create_name()

        while temp_name in Robot.names:
            temp_name = self.__create_name()

        return temp_name
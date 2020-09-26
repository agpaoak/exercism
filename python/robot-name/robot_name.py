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

    def __create_name(self):
        letters = string.ascii_uppercase
        name = [secrets.choice(letters) for i in range(2)]
        name.append(str(secrets.randbelow(1000)).zfill(3))
        return ''.join(name)

    def get_name(self):
        temp_name = self.__create_name()

        while temp_name in Robot.names:
            temp_name = self.__create_name()

        return temp_name
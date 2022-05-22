import re
from string import punctuation


class PhoneNumber:

    VALID_CHAR = '[^0-9]'
    INVALID_PUNCT = '!"#$%&\'*,/:;<=>?@[\\]^_`{|}~'

    def __init__(self, number):

        # Pre-Check for letters
        if any(c.isalpha() for c in number):
            raise ValueError('letters not permitted')

        # Pre-Check for invalid punctuation
        if any(p in number for p in self.INVALID_PUNCT):
            raise ValueError('punctuations not permitted')

        self.number = self.__clean_number(number)
        self.country_code = self.__get_country_code(number)
        self.area_code = self.__get_area_code(self.number)
        self.ex_code = self.__get_exchange_code(self.number)
        self.sub_num = self.__get_subscriber_num(self.number)

    def __clean_number(self, number):
        number = re.sub(self.VALID_CHAR, '', number)

        if len(number) > 11:
            raise ValueError('more than 11 digits')
        elif len(number) <= 9:
            raise ValueError('incorrect number of digits')
        elif len(number) == 11 and number[0] != '1':
            raise ValueError('11 digits must start with 1')
        return number

    def __get_country_code(self, number):
        cc = None
        if len(self.number) == 11:
            cc = self.number[0]
            # Side affect to assign self.number to a possible exchange code
            self.number = self.number[1:]
            if cc != '1':
                raise ValueError('Invalid Country Code')
        return cc

    def __get_area_code(self, number):
        area_code = number[0:3]

        if area_code[0] == '0':
            raise ValueError('area code cannot start with zero')
        elif area_code[0] == '1':
            raise ValueError('area code cannot start with one')
        return area_code

    def __get_exchange_code(self, number):
        ec = number[3:6]
        if ec[0] == '0':
            raise ValueError('exchange code cannot start with zero')
        elif ec[0] == '1':
            raise ValueError('exchange code cannot start with one')
        return ec

    def __get_subscriber_num(self, number):
        return number[6:10]

    def pretty(self):
        return f'({self.area_code})-{self.ex_code}-{self.sub_num}'

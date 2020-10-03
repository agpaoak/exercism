import re


class PhoneNumber:

    def __init__(self, number):
        self.number = self.__clean_number(number)
        self.country_code = self.__get_country_code(number)
        self.area_code = self.__get_area_code(self.number)
        self.ex_code = self.__get_exchange_code(self.number)
        self.sub_num = self.__get_subscriber_num(self.number)

    def __clean_number(self, number):
        number = re.sub('[^0-9]', '', number)
        if len(number) <= 9 or len(number) > 11:
            raise ValueError('Invalid number length')
        return number

    def __get_country_code(self, number):
        cc = None
        if len(self.number) == 11:
            self.country_code = self.number[0]
            self.number = self.number[1:]
            if self.country_code != '1':
                raise ValueError('Invalid Country Code')
        return None

    def __get_area_code(self, number):
        area_code = number[0:3]
        if area_code[0] <= '1':
            raise ValueError('Invalid Area Code')
        return area_code

    def __get_exchange_code(self, number):
        ec = number[3:6]
        if ec[0] <= '1':
            raise ValueError('Invalid Exchange Code')
        return ec

    def __get_subscriber_num(self, number):
        return number[6:10]

    def pretty(self):
        return f'({self.area_code})-{self.ex_code}-{self.sub_num}'

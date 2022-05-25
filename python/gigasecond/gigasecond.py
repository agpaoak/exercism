import math
import datetime

# A gigasecond is 10^9 (1,000,000,000) seconds.
# moment = class datetime
def add(moment):
    GIGASECOND = math.pow(10, 9)

    return moment + datetime.timedelta(seconds=GIGASECOND)
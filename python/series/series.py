def slices(series, length):

    if length <= 0:
        raise ValueError('Length cannot be 0 or less.')
    elif not series:
        raise ValueError('Series cannot be empty')
    elif length > len(series):
        raise ValueError('Length cannot be greater than the length of Series')
    elif len(series) >= length:        
        sliced = []
        for n in range(len(series)):
            value = series[n:n+length]
            if len(value) == length:
                sliced.append(value)
            else:
                break   
        return sliced

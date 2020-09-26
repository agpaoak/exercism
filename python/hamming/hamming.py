def distance(strand_a, strand_b):

    if len(strand_a) != len(strand_b):
        raise ValueError('Bad Match')

    return sum(1 for a, b in zip(strand_a, strand_b) if a != b)
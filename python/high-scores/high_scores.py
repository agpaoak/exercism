def latest(scores):
    length = len(scores)
    return scores[length-1]

def personal_best(scores):
    cp_scores = scores.copy()
    cp_scores.sort()
    return latest(cp_scores)

def personal_top_three(scores):

    cp_scores = scores.copy()

    if (len(scores) == 1):
        return cp_scores
    else:
        top_three = []
        cp_scores.sort()
        cp_scores.reverse()

        while(len(top_three) != 3) and (len(cp_scores) != 0 ):
            top_three.append(cp_scores.pop(0))

        return top_three

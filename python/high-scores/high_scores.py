def latest(scores):
    return scores[len(scores)-1]

def personal_best(scores):
    return latest(sort_asc(scores))

def personal_top_three(scores):
    cp_scores = sort_desc(scores)

    if (len(scores) == 1):
        return cp_scores
    else:
        top_three = []

        while   (len(top_three) != 3) and (
                len(cp_scores) != 0 ):
                
            top_three.append(cp_scores.pop(0))

        return top_three

def sort_desc(scores):
    cp_scores = sort_asc(scores)
    cp_scores.reverse()
    return cp_scores

def sort_asc(scores):
    cp_scores = scores.copy()
    cp_scores.sort()
    return cp_scores
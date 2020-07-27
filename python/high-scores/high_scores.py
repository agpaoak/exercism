def latest(scores):
    return scores[-1]

def personal_best(scores):
    return max(scores)

def personal_top_three(scores):
    temp_scores = sorted(scores, reverse=True)

    return temp_scores[0:3]
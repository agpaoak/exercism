def proteins(strand):
    # Codon Length
    CODON_LENGTH = 3

    # Dictionary - Protein : codon
    protein_list = {
        'Methionine': ['AUG'],
        'Phenylalanine': ['UUU', 'UUC'],
        'Leucine': ['UUA', 'UUG'],
        'Serine': ['UCU', 'UCC', 'UCA', 'UCG'],
        'Tyrosine': ['UAU', 'UAC'],
        'Cysteine': ['UGU', 'UGC'],
        'Tryptophan': ['UGG'],
        'STOP': ['UAA', 'UAG', 'UGA']
    }

    strands = [strand[n:n + CODON_LENGTH] for n in range(0, len(strand), CODON_LENGTH)]

    proteins = []
    run = True

    for strand in strands:

        if run:
            for protein, codon in protein_list.items():
                if strand in codon and protein == 'STOP':
                    run = False
                    break
                elif strand in codon:
                    proteins.append(protein)

    return proteins

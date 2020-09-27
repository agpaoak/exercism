def proteins(strand):
    S_LENGTH = 3
    
    protein_list = {
        'Methionine': ['AUG '],                  
        'Phenylalanine': [ 'UUU','UUC'],          
        'Leucine': ['UUA', 'UUG' ],             
        'Serine': ['UCU', 'UCC', 'UCA', 'UCG'],  
        'Tyrosine': ['UAU', 'UAC'] ,            
        'Cysteine': ['UGU', 'UGC'],              
        'Tryptophan': ['UGG'],               
        'STOP': ['UAA', 'UAG', 'UGA']         

    }
    
    strands = [strand[n:n + S_LENGTH] for n in range(0, len(strand), S_LENGTH)]
    
    proteins = []
    run = True
    
    for strand in strands:
        
        if run:
            for protein, codon in protein_list.items():
                if strand in codon and protein == 'STOP':
                    run = False
                elif strand in codon and protein not in proteins:
                    proteins.append(protein)
    
    return proteins

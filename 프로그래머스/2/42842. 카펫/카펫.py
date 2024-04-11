def solution(brown, yellow):
    answer = []
    hv = (brown -4) / 2
    half = int((hv // 2) + (hv % 2) + 1)

    for i in range(1, half): 
        left = int(hv - i)
        if((i * left) == yellow):
            if(i >= left):
                answer = [i+2 , left+2]
            else :
                answer = [left+2, i+2]

    return answer
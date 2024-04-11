def solution(n):
    count = format(n, 'b').count('1')

    for i in range(n+1, 1000000): 
        if(format(i, 'b').count('1') == count):
            return i
    return n
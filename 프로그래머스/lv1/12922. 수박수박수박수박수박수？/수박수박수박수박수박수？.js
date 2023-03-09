function solution(n) {
    
    var answer = '';
    var i=0;
    for(i=1;i<=n;i++){
        if(i%2==1)
        {
            answer += '수';
        }
        else
        { // if(i%2==0)
            answer += '박';
        }
    }
    return answer;
}
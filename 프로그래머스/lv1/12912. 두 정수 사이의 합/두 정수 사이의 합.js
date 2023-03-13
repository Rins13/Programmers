function solution(a, b) 
{
    var answer = 0;
    var temp = 0;
    var error = 777;

     
    if(!(a%1 == 0 && b%1 ==0))
      { // a,b가 0 이 아닐 때
          if(!(Number.isInteger(a)) || !(Number.isInteger(b)))
          { // 정수가 아니라면 error발생
             return error;
           }
          if( a< -10000000 || a > 10000000 || b < -10000000 || b > 10000000)
          { // 지정된 범위의 수가아니라면 error발생
        return error;
      }
    }
   
    if(a == b)
    { // a,b 같은수라면 a값 리턴
        answer = a;
    }
    else
    {
        if (a>b)
        { // a>b의 경우 순서변경
            temp = a;
            a=b;
            b=temp;
        }
        while(a<(b+1))
        { // a~b의 값 더하기
            answer = answer + a;
            a++;
        }
    }
    return answer;
}
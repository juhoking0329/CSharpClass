using UnityEngine;

//조건문(If) : 특정 조건에 맞는 명령문을 실행하는 제어문
//(if, switch)
public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 점수가 60점이상이면 "합격"을 출력
        /*int score = 60;
        if (score >= 60)    //조건식 
        {
            //실행문
            Debug.Log("합격");    
        }*/

        /*int score = 60;
        if (score >= 60)    //실행문이 하나이면 {} 생략 가능
            Debug.Log("합격");*/

        //중첩 if문 : if문 안에 또 다른 if문이 있는 형태
        string name = "홍길동";
        int age = 20;

        //만약 이름이 홍길동과 같으면 실행문 실행
        if (name == "홍길동")
        {
            //실행문 : 만약 나이가 20과 같으면 실행문 실행
            if (age == 20)
            {
                //실행문
                Debug.Log($"이름은 {name}, 나이는 {age}살.");
            }
        }
 
    }
}

/*
[1]if문
조건식이 참일때 명령문을 실행
조건식이 거짓일때 명령문을 실행하지 않는다

만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라
if(조건식)
{
    //실행문1
    //실행문2
    //..........
}


[2]else문 : if문과 같이 사용
만약 조건식이 참이면 if문 안에 있는 실행문1을 실행하고, else문 안에 있는 실행문2는 실행하지 마라
만약 조건식이 거짓이면 if문 안에 있는 실행문1은 실행하지 말고, else문 안에 있는 실행문2를 실행하라
조건식이 거짓일때 명령문을 실행
if(조건문)
{
    //실행문1
}
else
{
    //실행문2
}

//실행문3

1. 조건식이 참
실행문 1 -> 실행문3 실행

2. 조건식이 거짓
실행문 2 -> 실행문3 실행


[3]else if문 : if문과 같이 사용
if(조건식1)
{
    //실행문1
}
else if(조건식2)
{
    //실행문2
}
else
{
    //실행문3
}

//실행문4

1. 조건식1 : 참
실행문1 -> 실행문4

2. 조건식1 : 거짓, 조건식2: 참
실행문2 -> 실행문4

3. 조건식 1,2 : 거짓
실행문3 -> 실행문4

4. 조건식 1, 2 : 참
실행문1 -> 실행문4



*/
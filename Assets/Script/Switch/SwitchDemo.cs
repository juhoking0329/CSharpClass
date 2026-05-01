using UnityEngine;

public class SwitchDemo : MonoBehaviour
{
    //점수 데이터값 입력
    public int num = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //num이 1이면 num은 1입니다 출력
        //num이 2이면 num은 2입니다 출력
        //다른 수이면 아무것도 안한다

        switch (num) //num데이터 판별
        {
            case 1:
                Debug.Log($"{num}은 1입니다");
                break;

            case 2:
                Debug.Log($"{num}은 2입니다");
                break;
        }
    }
}

/*
switch문
조건 데이터의 값에 따라 명령문을 실행

switch(조건 Data) 값 판별
{
    case 1번:
        //실행문1
        break;
    case 2번:
        //실행문2
        break;
    case 3번:
        //실행문3
        break;

    default:        //모든 경우가 아니면
        //실행문4
*/
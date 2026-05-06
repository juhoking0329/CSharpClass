using UnityEngine;

// 연산자(Operator) : 변수나 상수에 저장된 데이터를 처리하는 기호(+, -, *, /, % 등등)
public class OperatorDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1]UnaryOperator(단항 연산자) : 하나의 피연산자에 적용되는 연산자 (+, -)
        int value = 0;  //정수형 변수 value 선언과 동시에 0으로 초기화하기

        value = 8;      //정수형 변수 value에 8을 저장하기
        value = +value; //정수형 변수 value에 + value값을 저장하기
        Debug.Log(value);   //8

        value = -8;     //정수형 변수 value에 -8을 저장하기
        value = +value; //정수형 변수 value에 + value값을 저장하기
        Debug.Log(value);   //-8

        value = 8;      //정수형 변수 value에 8을 저장하기
        value = -value; //정수형 변수 value에 - value값을 저장하기
        Debug.Log(value);   //-8

        value = -8;     //정수형 변수 value에 -8을 저장하기
        value = -value; //정수형 변수 value에 - value값을 저장하기
        Debug.Log(value);   //8


        // [2]BinaryOperator(이항 연산자) : 두 개의 피연산자에 적용되는 연산자 (+, -, *, /, % <- 나머지 연산)
        int i = 5;
        int j = 3;

        int k;

        k = i + j;
        Debug.Log(k);       //8

        k = i - j;
        Debug.Log(k);       //2

        k = i * j;
        Debug.Log(k);       //15

        k = i / j;
        Debug.Log(k);       //1

        k = i % j;
        Debug.Log(k);       //2

    }
}

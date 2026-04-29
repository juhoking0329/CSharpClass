using UnityEngine;

//
public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] float 형 변수 선언하고 초기화하기
        float f = 3.14f;
        Debug.Log(f);

        //[2] double 형 변수 선언하고 초기화하기
        double d = 3.141592d;
        Debug.Log(d);

        //[3] decimal 형 변수 선언하고 초기화하기
        decimal pi = 3.1415926535897932384626433832m;
        Debug.Log(pi);
    }
}

/*
실수형 데이터
float : 32비트 실수형 데이터 형식
double : 64비트 실수형 데이터 형식
decimal : 128비트 실수형 데이터 형식
*/
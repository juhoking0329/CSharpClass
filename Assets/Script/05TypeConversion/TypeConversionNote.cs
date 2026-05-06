using UnityEngine;

//형식 변환 실습
public class TypeConversionNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double 형 변수 d 선언과 12.34로 초기화
        double D = 12.34;   //실수형 64bit
        //int 형 변수 i 선언과 d 변수에 있는 값을 1234로 저장하기(초기화)
        int I = 1234;       //정수형 32bit

        //[1] d에 i값 저장하기 : double > int 묵시적(암묵적, 암시적) 형식 변환
        D = I;
        Debug.Log($"형식변환: {D}");

        D = 12.34;
        I = 1234;

        //[2] i에 d값 저장하기 : int > double 명시적 형식 변환
        I = (int)D; // () 캐스트 연산자
        Debug.Log($"형식변환: {I}");

        D = 12.34;
        I = 1234;

        //[3] 숫자가 아닌 다른 형식간의 변환
        //문자열 변수 선언하고 초기화
        string S = "";      //빈값으로 문자열 초기화
        //s에 d값 저장하기
        S = D.ToString();   //숫자를 문자열로 형식변환하기
        Debug.Log($"형식변환: {S}");

        //s에 i값 저장하기
        S = I.ToString();
        Debug.Log($"형식변환: {S}");
    }

}
using UnityEngine;

// + 더하기 연산의 추가 기능, 문자열 연결 연산자
public class OperatorNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "World");
        Debug.Log("Hi" + " " + "Everyone");

        Debug.Log("123" + "456");                   //123456 : 문자열 + 문자열 => 문자열 연결
        Debug.Log("123" + 456);                     //123456 : 문자열 + 숫자 => 문자열 연결
        Debug.Log(123 + "456" + 789 + 890);         //123456789890 : 숫자 + 문자열 => 문자열 연결
        Debug.Log(123 + 456);                       //579 : 숫자 + 숫자 => 덧셈

        Debug.Log("123" + true);                    //123true : 문자열 + bool 형식 => 문자열 연결

        //Debug.Log("123" - 456);                   //버그

        //질문
        Debug.Log(111 + 222 + 333 + 444 + "5");       //1112223334445 : 숫자 + 숫자 + 숫자 + 숫자 + 문자열 => 문자열 연결



    }

}

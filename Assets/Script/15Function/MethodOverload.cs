using UnityEngine;

//메서드(함수) 오버로드(Method Overload) : 동일한 이름의 메서드를 매개변수를 다르게 해서 여러개 생성
//함수 다중 정의
public class MethodOverload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
        PrintNumber(1234);
        PrintNumber(1234F);
        PrintNumber(1234L);
    }

    //매개변수로 숫자(정수, 실수)를 입력받아 출력하는 함수(PrintNumber)
    void PrintNumber(int number)
    {
        Debug.Log($"int32 : {number}");
    }
    void PrintNumber(float number)
    {
        Debug.Log($"실수형F : {number}");
    }
    void PrintNumber(long number)
    {
        Debug.Log($"int64 : {number}");
    }
}

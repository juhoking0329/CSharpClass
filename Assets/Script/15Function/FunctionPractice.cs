using UnityEngine;

// 두개의 정수를 입력받아 더하기, 빼기, 곱하기, 나누기(0으로 나누기 제외), 나머지 값을 구하는 프로그램 구현
public class FunctionPractice : MonoBehaviour
{
    //인스펙터창 입력
    public int a = 0;
    public int b = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("계산기 가동");

        //결과를 출력
        Debug.Log($"{a} + {b} = {Add(a, b)}");
        Debug.Log($"{a} - {b} = {Subtract(a, b)}");
        Debug.Log($"{a} * {b} = {Multiply(a, b)}");

        if (b != 0)
        {
            Debug.Log($"{a} / {b} = {Divide(a, b)}");
            Debug.Log($"{a} % {b} = {Remainder(a, b)}");
        }
        else
        {
            Debug.Log("주의: 0으로는 나눌 수 없습니다.");
        }
    }

    //더하기
    int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //빼기
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    //곱하기
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    //나누기
    int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    //나머지
    int Remainder(int num1, int num2)
    {
        return num1 % num2;
    }
}

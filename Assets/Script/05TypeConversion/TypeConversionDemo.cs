using UnityEngine;

//Type Conversion : 형식 변환, 서로 다른 데이터 형식 간의 변환
public class TypeConversionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long 형 변수 선언하고 long형 변수가 저장할 수 있는 가장 큰 값으로 초기화하기
        long l = long.MaxValue;
        Debug.Log($"l의 값: {l}");

        //[2] int 형 변수에 l 변수에 있는 값을 저장하기(초기화)
        int i = (int)l; // 오류 발생: long형 값을 int형 변수에 저장할 수 없음
        Debug.Log($"i의 값: {i}");
    }
}

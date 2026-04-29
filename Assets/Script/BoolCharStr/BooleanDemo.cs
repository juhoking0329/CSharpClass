using UnityEngine;

// bool : 논리형 데이터 형식, true 또는 false의 값을 저장
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool 변수 선언과 초기화하기
        bool bIn = true; //참
        Debug.Log("bIn: " + bIn);

        bool isOut = false; //거짓
        Debug.Log("isOut: " + isOut);
        
    }
}

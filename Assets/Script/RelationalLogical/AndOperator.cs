using UnityEngine;

//AndOperator(And 연산자) : 둘 다 참(true)일 때만 참
//결과 : 참 또는 거짓 (bool 형식)
//두개의 bool형이 연산할때 둘다 참일때 참이고 나머지는 거짓
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참일때만 연산의 결과 참
        Debug.Log(true && true);     //true

        //[2] 둘 중 하나라도 거짓이면 연산의 결과 거짓
        Debug.Log(true && false);     //false
        Debug.Log(false && true);     //false

        //[3] 둘 다 거짓이면 연산의 결과 거짓
        Debug.Log(false && false);    //false
    }
}

using UnityEngine;

//NotOperator(Not 연산자, !) : 피연산자가 참(true)일 때 거짓(false), 거짓(false)일 때 참(true)로 반전시키는 연산자
//결과 : 참 또는 거짓 (bool 형식)
public class NotOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log(!true);     //false
        //Debug.Log(!false);    //true

        bool isOut = false;

        Debug.Log(!isOut);          //true
        Debug.Log(!!isOut);         //false
        Debug.Log(!(!(!isOut)));    //true
    }
}

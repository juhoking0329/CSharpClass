using UnityEngine;

// var : 암시적으로 형식화된 로컬 변수
public class VarDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // string 타입의 name 변수 선언과 동시에 "홍길동"으로 초기화하기
        var name = "홍길동";   // 초기화된 "홍길동" 값을 보고 name 변수의 타입이 string으로 결정된다.
        Debug.Log(name);
        Debug.Log("name 타입: " + name.GetType());

        // double 타입의 version 변수 선언과 동시에 8.1으로 초기화하기
        var version = 8.1;      // 초기화된 8.1 값을 보고 version 변수의 타입이 double로 결정된다.
        Debug.Log(version);
        Debug.Log("version 타입: " + version.GetType());


        var car = 100;
        Debug.Log(car);
        Debug.Log("car 타입 : " + car.GetType());
    }
}

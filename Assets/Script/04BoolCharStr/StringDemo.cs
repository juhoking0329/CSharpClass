using UnityEngine;

// string : 문자열 데이터 형식, 문자(char)들의 집합
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] string 변수 선언하고 초기화
        string name = "홍길동";
        //[1-1] int 상수 선언과 동시에 초기화하기
        const int AGE = 20;

        //[2] 사용하기
        Debug.Log("name: " + name);     //문자열 + 문자열 => 문자열 연결
        Debug.Log($"내 이름은 {name}");  //문자열 보간법 => $"{변수명}"

        //연습하기
        //문자열 보간법으로 콘솔창에 "안녕하세요 홍길동 입니다" 를 출력해보세요
        Debug.Log($"안녕하세요 {name} 입니다");
        //이름은 홍길동 나이는 20살입니다 출력하시오
        Debug.Log($"이름은 {name}, 나이는 {AGE}살입니다");

        //이름은 이순신, 나이는 40살 입니다. 출력하시오
        name = "이순신";
        //AGE = 40; AGE는 상수이므로 값을 변경할 수 없다.
        Debug.Log($"이름은 {name}, 나이는 {AGE}살입니다");
    }
}

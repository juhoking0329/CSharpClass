using UnityEngine;

//순차문 : 위에서 아래로 순서대로 명령문을 실행
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //국어점수와 영어점수로 총점을 구하고 평균을 구하는 프로그램
        int kor = 100;
        int eng = 90;
        
        int total = 0;
        double avg = 0.0;

        total = kor + eng;      //총점 구하기
        avg = total / 2.0;      //평균 구하기

        Debug.Log($"총점 : {total}");    //190
        Debug.Log($"평균 : {avg:F1}");      //95.0   


    }

}

/*
*제어문 : 프로그램의 흐름(순서)을 제어하는 명령문
1. 순차문(Sequence) : 프로그램이 위에서 아래로 한 줄씩 차례대로 실행되는 제어문

2. 조건문(If) : 특정 조건에 맞는 명령문을 실행하는 제어문

3. 반복문(Loop) : 특정 조건이 만족될 때까지 반복적으로 실행되는 제어문
*/



using UnityEngine;

//학점을 출력하는 프로그램
//점수가 90이상이면 A 출력, 80이상이면 B 출력, 70 이상이면 C 출력
//60점 이상이면 D 출력, 나머지 F 출력
//학점 : A
public class ElseIfDemo : MonoBehaviour
{
    //스코어 입력
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //학점을 출력하는 프로그램
        if (score >100 || score < 0)
            {
            Debug.Log("학점 : 오류 발생");
            }
        else if (score >= 90)
            {
            Debug.Log("학점 : A");
            }
        else if (score >= 80)
            {
            Debug.Log("학점 : B");
            }
        else if (score >= 70)
            {
            Debug.Log("학점 : C");
            }
        else if (score >= 60)
            {
            Debug.Log("학점 : D");
            }
        else
            {
            Debug.Log("학점 : F");
            }
    }
}

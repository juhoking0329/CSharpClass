using UnityEngine;

//점수가 60점 이상이면 "합격", 그렇지 않으면 "불합격"을 출력하는 프로그램
public class ElseDemo : MonoBehaviour
{
    //점수 입력
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (score >= 60) //점수가 60점 이상이면
        {
            //실행문 : 합격 출력
            Debug.Log("합격");
        }
        else //점수가 60점 미만이면
        {
            //실행문 : 불합격 출력
            Debug.Log("불합격");
        }
    }
}

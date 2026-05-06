using UnityEngine;

//이중 for문 : for문 안에 for문
//삼중 for문 : for문 안에 for문이 있고 안에 있는 for문 안에 for문
public class ForStar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //* 로 삼각형 만들기
        /*for (int i = 1; i <= 5; i++)
        {
            Debug.Log($"*를 {i}개 만큼 찍는다");
            for(int j = 0; j < i; j++)  //i만큼 반복하라
            {
                //반복실행문 - i번 만큼
                Debug.Log("*"); 
            }
        }*/

        for (int i = 1; i <= 5; i++)
        {
            string stars = ""; // 한 줄에 찍을 별들을 담을 바구니

            // 안쪽 루프: '별의 개수'를 담당합니다.
            // i(현재 층수)만큼 별을 바구니에 담아요.
            for (int j = 1; j <= i; j++)
            {
                stars += "*";
            }

            // 한 줄이 완성되면 콘솔에 출력
            Debug.Log(stars);
        }
    }
}

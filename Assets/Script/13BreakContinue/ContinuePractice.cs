using UnityEngine;

//[Q] 1부터 100까지의 합을 구하는 프로그램 구현
//단 1부터 100까지 중 3의 배수는 합에서 제외한다
public class ContinuePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            // 만약 3의 배수이면
            if (i % 3 == 0)
            {
                continue;
            }
            //반복실행문
            sum += i; 
        }

        // 최종 결과 출력
        Debug.Log($"최종 합계: {sum}");
    }
}

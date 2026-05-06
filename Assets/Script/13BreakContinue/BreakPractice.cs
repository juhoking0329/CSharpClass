using UnityEngine;

// 1부터 10까지의 정수의 합을 구하는 프로그램 구현
// 단, 합을 구하다가 합이 22 이상이 되면 더이상 합을 구하지말고 합을 출력하라
public class BreakPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; // 합계를 담을 바구니

        // 1부터 10까지 1씩 증가하며 반복
        for (int i = 1; i <= 10; i++)
        {
            sum += i; // sum = sum + i; 와 동일

            // 만약 합이 22 이상이 되면
            if (sum >= 22)
            {
                Debug.Log($"합이 22 이상({sum})이 되어 계산을 중단합니다. 마지막 더한 수: {i}");
                break; // 반복문 종료
            }
        }

        // 최종 결과 출력
        Debug.Log($"최종 합계: {sum}");
    }
}

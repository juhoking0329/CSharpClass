using UnityEngine;

//정수형 배열 방3개
//1번째 방 1, 2번째 방 2, 3번째 방 3
public class Array1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers;

        numbers = new int[3];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        Debug.Log($"{numbers[0]}");
        Debug.Log($"{numbers[1]}");
        Debug.Log($"{numbers[2]}");
    }

}

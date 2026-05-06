using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;

        Debug.Log($"처음 값 i : {i}, j : {j}");

        // 1. i의 값을 임시 보관함(temp)에 잠시 맡겨요.
        int temp = i;

        // 2. 이제 i는 안심하고 j의 값을 가져옵니다.
        i = j;

        // 3. j는 아까 맡겨두었던 i의 원래 값(temp)을 가져옵니다.
        j = temp;

        Debug.Log($"변경 후 i : {i}, j : {j}");
    }
}

/* 
[Q]
+, - 다른 연산없이 변수 i, j의 값을 서로 바꾸어서 저장하기

[output]
처음 값 i : 100, j : 200
변경 후 i : 200, j : 100
 */
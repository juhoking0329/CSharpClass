using UnityEngine;
using System;

public class RandomPractice : MonoBehaviour
{
    // [2] 임의의 숫자 6개를 저장할 공간 (배열)
    public int[] lottoNumbers = new int[6];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //로또번호 생성기
        GenerateLotto();
        PrintLotto();
    }

    // [1] 임의의 숫자 6개 생성 및 저장 함수
    void GenerateLotto()
    {
        // System에 있는 Random 클래스를 호출하여 'random'이라는 이름의 새로운 인스턴스를 생성
        System.Random random = new System.Random();

        // 배열의 길이(lottoNumbers.Length = 6)만큼 반복문을 실행(0부터 5까지 총 6번)
        for (int i = 0; i < lottoNumbers.Length; i++)
        {
            // 생성한 random 도구를 사용하여 1~45 사이의 정수를 뽑아 배열의 i번째 칸에 저장
            lottoNumbers[i] = random.Next(1, 46);

            // [2] 중복 검사: 방금 뽑은 번호(i번째)를 
            // 이전까지 뽑았던 번호들(j = 0부터 i-1까지)과 비교합니다.
            for (int j = 0; j < i; j++)
            {
                if (lottoNumbers[i] == lottoNumbers[j])
                {
                    // [3] 만약 똑같은 숫자가 이미 있다면, 현재 칸(i)의 번호가 무효이므로 다시 뽑아야 합니다.
                    // i를 하나 뒤로 밀어서 현재 순서를 다시 반복
                    i--;

                    break;
                }
            }
        }
    }

    // [3] 임의의 숫자 6개 출력 함수
    void PrintLotto()
    {
        //문자열(string) 변수를 선언하고 초기화
        string result = "이번 주 로또 번호: ";

        // 배열에 저장된 6개의 숫자를 배열의 길이만큼 반복
        for (int i = 0; i < lottoNumbers.Length; i++)
        {
            result += lottoNumbers[i]; //우선 숫자 초기화

            // 만약 현재 순서(i)가 마지막 칸이 아니라면?
            if (i < lottoNumbers.Length - 1)
            {
                result += ", "; // 쉼표를 붙여준다
            }
        }
        // 완성된 문자열(result)을 출력
        Debug.Log(result);
    }
}


/*
//로또번호 생성기
[1] 6개 번호
[2] 1~45번 사이의 랜덤번호
[3] 6개 번호가 중복이 되면 안된다

3가지 조건이 맞는 6개의 번호를 출력하는 프로그램 구현

[1] 임의의 숫자 6개 번호 생성 : (1~45) 사이의 랜덤값
[2] 임의의 숫자 6개를 번호 저장
[3] 임의의 숫자 6개를 번호 출력

[4] 중복 제거 기능 추가 - [2]와 [3]번 사이에 추가

*/

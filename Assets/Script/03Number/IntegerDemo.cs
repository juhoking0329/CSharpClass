using UnityEngine;

//숫자 데이터 형식 사용하기 : 정수형, 실수형
//정수형(Integer)
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Signed Integer (부호(±)가 있는 정수형 데이터 형식)
        sbyte iSbyte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = 9223372036854775807;

        Debug.Log("iSbyte" + iSbyte);
        Debug.Log("iInt16" + iInt16);
        Debug.Log("iInt32" + iInt32);
        Debug.Log("iInt64" + iInt64);

        //UnSignedInteger (부호(±)가 없는 정수형 데이터 형식)
        byte iByte = 255;
        ushort iUInt16 = 65535;
        uint iUInt32 = 4294967295;
        ulong iUInt64 = 18446744073709551615;

        Debug.Log("iByte" + iByte);
        Debug.Log("iUInt16" + iUInt16);
        Debug.Log("iUInt32" + iUInt32);
        Debug.Log("iUInt64" + iUInt64);
    }
}


/* 
 * 정수형(Integer)
 * - 소수점이 없는 숫자 데이터 형식
 * - 양의 정수, 음의 정수, 0을 표현할 수 있음
 * - C#에서 정수형은 여러 가지 크기와 범위를 가지는 다양한 타입이 있음
 *   - byte: 0부터 255까지의 양의 정수 (8비트)
 *   - sbyte: -128부터 127까지의 정수 (8비트)
 *   - short: -32,768부터 32,767까지의 정수 (16비트)
 *   - ushort: 0부터 65,535까지의 양의 정수 (16비트)
 *   - int: -2,147,483,648부터 2,147,483,647까지의 정수 (32비트)
 *   - uint: 0부터 4,294,967,295까지의 양의 정수 (32비트)
 *   - long: -9,223,372,036,854,775,808부터 9,223,372,036,854,775,807까지의 정수 (64비트)
 *   - ulong: 0부터 18,446,744,073,709,551,615까지의 양의 정수 (64비트)
 * 
 * 예시:
 * int score = 100; // 점수를 나타내는 변수
 * long population = 7800000000; // 세계 인구를 나타내는 변수
 */

/*
1Byte: 8bit
1bit: 0 또는 1 데이터를 저장하는 최소 단위
8bit: 2^8 = 256가지의 서로 다른 값을 표현할 수 있음

1111 1111 : 255
0000 0000 : 0
0000 0001 : 1
0000 0010 : 2
0000 0011 : 3
0000 0100 : 4
0000 0101 : 5
0000 0110 : 6
0000 0111 : 7
0000 1000 : 8
0000 1001 : 9
0000 1010 : 10
0000 1011 : 11
0000 1100 : 12
0000 1101 : 13
0000 1110 : 14
0000 1111 : 15


sbyte: -128 ~ 127

byte: 0 ~ 255






*/
using UnityEngine;

namespace Constructor
{
    //강아지를 관리하는 클래스
    public class Dog
    {
        //[1] 필드
        private string name;    //이름
        
        //[2] 생성자 - 필드 초기화 설정
        //매개변수로 이름을 받은 name에 대입
        //생성자 호출 강아지이름 만들어 준다
        public Dog(string str) 
        { 
            name = str;
        }

        //[3] 메서드 - 강아지 이름을 반환하는 함수
        public string Getname()
        {
            return name;
        }
    }
}

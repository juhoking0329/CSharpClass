using UnityEngine;

namespace PrivatePublic
{
    //유저를 관리하는 클래스
    public class User
    {
        //필드(전역변수, 멤버변수) 선언, public, private
        public string name;     //이름, public
        private int age;        //나이, private
        string address;         //주소, private

        //함수 메서드, public, private
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }
        private void Bye()
        {
            Debug.Log("안녕히 계세요");
        }

        //private한 age(필드)를 외부에서 공개하고자 할때 public한 메서드를 이용한다
        //매개변수로 나이를 입력받아 age값을 세팅하는 함수 
        public void SetAge(int value)
        {
            age = value;
        }

        //age를 반환하는 함수 구현
        public int GetAge()
        {
            return age;
        }
    }
}

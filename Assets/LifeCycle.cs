using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //프로그램이 시작하면 딱 한번만 제일 먼저 수행되는 함수
    void Awake(){
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void Start(){
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    //유니티엔진이 물리연산을 하기전에 일어나는 업데이트 함수
    //고정된 실행 주기로 cpu를 사용(부하가 걸림)
    void FixedUpdate(){
        Debug.Log("이동!");
    }
}

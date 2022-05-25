using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //프로그램이 시작하면 딱 한번만 제일 먼저 수행되는 함수
    void Awake(){
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    //게임 오브젝트가 활성화될때마다 사용
    void OnEnable(){
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    void Start(){
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    //유니티엔진이 물리연산을 하기전에 일어나는 업데이트 함수
    //고정된 실행 주기로 cpu를 사용(부하가 걸림)
    void FixedUpdate(){
        Debug.Log("이동!");
    }

    //60프레임으로 동작하기때문에 왠만하면 update가 주기가 더 길다
    void Update(){
      Debug.Log("몬스터 사냥!");  
    }

    //모든 업데이트 후에 진행되는 업데이트, 후처리나 카메라 등등에 사용됨
    void LateUpdate(){
        Debug.Log("경험치 획득");
    }

    void OnDisable(){
        Debug.Log("플레이어 데이터가 로그아웃 되었습니다.");
    }

    //오브젝트가 삭제될때 쓰는 함수
    void OnDestroy(){
        Debug.Log("플레이어 데이터가 해제되었습니다.");
    }
}

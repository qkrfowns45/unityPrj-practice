using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobj : MonoBehaviour
{
    void Update()
    {
        //아무 입력을 최초로 받을 때 true
        if(Input.anyKeyDown){
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        //아무 입력을 최초로 받을 때 true
        // if(Input.anyKey){
        //     Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        // }

        //모든 클릭은 눌렀을때 누르고 있을때 올라올때 세가지가 있다. 
        // if(Input.GetKeyDown(KeyCode.W)){
        //     Debug.Log("키를 다운하고 있습니다.");
        // }
        // if(Input.GetKey(KeyCode.LeftArrow)){
        //     Debug.Log("키가 눌러진 상태입니다.");
        // }
        // if(Input.GetKeyUp(KeyCode.RightArrow)){
        //     Debug.Log("키에서 손을 떼셨습니다.(올라오는 상태)");
        // }

        // //마우스 왼쪽은 0 마우스 오른쪽은 1 
        // if(Input.GetMouseButtonUp(0)){
        //     Debug.Log("마우스 클릭!");
        // }

        if(Input.GetButtonDown("Fire1")){
            Debug.Log("점프!");
        }

        if(Input.GetButton("Jump")){
            Debug.Log("점프.....");
        }

        if(Input.GetButtonUp("Jump")){
            Debug.Log("점프!!");
        }

        //횡이동
        // if(Input.GetButton("Horizontal")){
        //     Debug.Log("횡 이동 중..." 
        //     + Input.GetAxis("Horizontal"));
        // }
        if(Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..." 
            + Input.GetAxisRaw("Horizontal"));
        }
        //종이동
        if(Input.GetButton("Vertical")){
            Debug.Log("종 이동 중..." 
            + Input.GetAxisRaw("Vertical"));
        }        
    }
}

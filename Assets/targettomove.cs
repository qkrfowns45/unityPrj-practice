using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targettomove : MonoBehaviour
{
    Vector3 target = new Vector3(3,0.85f,0);

    void Awake() {
        Application.targetFrameRate = 30;
    }
    // Update is called once per frame
    void Update()
    {
        //현재위치, 목표, 속도로 구성된 함수
        //transform.position = Vector3.MoveTowards(transform.position,target,1f);

        //2.SmoothDamp
        // Vector3 velo = Vector3.zero;
        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3.Lerp
        transform.position = Vector3.Lerp(transform.position, target, 0.05f);
        
        //4.Slefp-구면 선형보간 호를 그리며 이동
        //transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
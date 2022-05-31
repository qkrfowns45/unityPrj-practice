using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealMove : MonoBehaviour
{
    void Awake() {
        Application.targetFrameRate = 30;
    }
    void Start()
    {
    }

    void Update(){
        //오브젝트 변수 transform을 항상 가지고 있음
        //3차원의 벡터값을 뜻하는 vector3
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0); 
        transform.Translate(vec);
    }
}

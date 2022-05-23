using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity");

        //1.변수
        int level = -5;
        float strength = 15.5f;
        string playerName = "플레이어1";
        bool isFullLevel = false;

        //2.그룹형 변수
        string[] monster = {"슬라임", "사막뱀", "악마"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monster[0]);
        Debug.Log(monster[1]);
        Debug.Log(monster[2]);

        Debug.Log("맵에 존재하는 몬스터 레벨");
        Debug.Log(monster[0]+monsterLevel[0]);
        Debug.Log(monster[1]+monsterLevel[1]);
        Debug.Log(monster[2]+monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);
        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
    }
}

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

        //3.연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp/300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        //4.키워드
        //프로그래밍 언어를 구성하는 특별한 단어

        //5.조건문
        //6.반복문

        //7.클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나검사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());
    }
}

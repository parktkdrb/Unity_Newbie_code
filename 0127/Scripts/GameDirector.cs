using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject player; // 플레이어 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject swordman; // 목표물 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject distance; // 플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI 오브젝트를 대입할 변수

    void Start()
    {
        this.player = GameObject.Find("testplayer");
        this.swordman = GameObject.Find("swordman");
        this.distance = GameObject.Find("이동거리");
    }



    void Update()
    {
       
        float lengthDis = this.swordman.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표지점" + ":" + lengthDis.ToString("F2") + "M";
            //ToString("D숫자") 정수형, 숫자는 자리수 D4 천자리 숫자 400일경우 0400으로 찍힘.
            //ToString("F숫자") 소수점이하자리수
        }
        else //lengthDis 가 0(제로)보다 작아졌다면
        {
            this.distance.GetComponent<Text>().text = "Game Over!\n 스페이스바를 눌러서 게임 종료"; // Game Over 출력
        }
        }
}

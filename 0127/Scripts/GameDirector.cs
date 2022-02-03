using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject player; // �÷��̾� ������Ʈ�� ������ ���� �������� GameObject
    GameObject swordman; // ��ǥ�� ������Ʈ�� ������ ���� �������� GameObject
    GameObject distance; // �÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI ������Ʈ�� ������ ����

    void Start()
    {
        this.player = GameObject.Find("testplayer");
        this.swordman = GameObject.Find("swordman");
        this.distance = GameObject.Find("�̵��Ÿ�");
    }



    void Update()
    {
       
        float lengthDis = this.swordman.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + lengthDis.ToString("F2") + "M";
            //ToString("D����") ������, ���ڴ� �ڸ��� D4 õ�ڸ� ���� 400�ϰ�� 0400���� ����.
            //ToString("F����") �Ҽ��������ڸ���
        }
        else //lengthDis �� 0(����)���� �۾����ٸ�
        {
            this.distance.GetComponent<Text>().text = "Game Over!\n �����̽��ٸ� ������ ���� ����"; // Game Over ���
        }
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float Speed = 0; // ���� ����
    Vector2 startPos; // 2������ǥ�� ���Ͱ�(x,y) 3������ǥ�� ���Ͱ�(x,y,z)
    //Vector2�� 2������ǥ���� �����ϴ�.(x,y), Vetor3(x,y,z)
    Vector2 endpos; // ���콺�� ������ ���������� ��ġ���� �� ����
    public float �и� = 1000.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0))//���콺 ���ʹ�ư�� ������ 
        {
            this.startPos = Input.mousePosition; // ���콺��ư���� ���������� ��ġ��(x,y)
        }
        else if(Input.GetMouseButtonUp(0)) {
            Vector2 endPos = Input.mousePosition; // ���콺��ư���� �����ٰ� ���������� ��ġ��(x,y)
            float length = (this.endpos.x - this.startPos.x); // ������ ��ǥ�� - ó�� ��ǥ���� ���ݴϴ�.
            this.Speed = length / �и�;

            GetComponent<AudioSource>().Play();
        } 
        transform.Translate(this.Speed, 0, 0);//�̵� x+����
        this.Speed *= 0.98f;//����

    }
}

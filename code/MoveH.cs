using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 1.0f; //�ӵ���, �� ������ �ۺ��̱� ������ �ν��大�Ϳ��� ������ �����ϴ�.
 

    // Update is called once per frame
    void FixedUpdate()// �� �����Ӹ��� ��� �����Ѵ�.(�����ð�����)
    {
        this.transform.Translate(speed / 50, 0, 0); // �����̵�(+x�� �������� �̵�)
    }
}

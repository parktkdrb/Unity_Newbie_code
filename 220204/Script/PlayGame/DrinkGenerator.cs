using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkGenerator : MonoBehaviour
{
    public GameObject ��������;
    public float respan1 = 5; //���������� ��Ÿ���� �ð�(������ �ð�)
    float delta1 = 0;// ������ �ð��� ���ϱ� ���� �ð� ����


    void Update()
    {
        this.delta1 += Time.deltaTime; //this.delta = this.delta + Time.deltaTime;     
        if (this.delta1 > this.respan1)
        {
            this.delta1 = 0;
            GameObject copyDrink = Instantiate(��������) as GameObject;
            int range1 = Random.Range(-18, 18); // Random.Range(�ּҰ�, �ִ밪)
            copyDrink.transform.position = new Vector3(range1, 11, 0);
        }
    }
}


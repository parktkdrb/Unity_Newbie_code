using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject ¬��ź;
    public float respan = 0.5f; //¬��ź�� ��Ÿ���� �ð�(������ �ð�)
    float delta = 0;// ������ �ð��� ���ϱ� ���� �ð� ����
    public GameObject ��������;
    float respan1 = 3; //���������� ��Ÿ���� �ð�(������ �ð�)
    float delta1 = 0;// ������ �ð��� ���ϱ� ���� �ð� ����

    void Update()
    {
        this.delta += Time.deltaTime; //this.delta = this.delta + Time.deltaTime;     
        if(this.delta > this.respan)
        {
            this.delta = 0;
            GameObject copyBomb = Instantiate(¬��ź) as GameObject;
            int range = Random.Range(-18, 18); // Random.Range(�ּҰ�, �ִ밪)
            copyBomb.transform.position = new Vector3(range, 11, 0);

        }
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

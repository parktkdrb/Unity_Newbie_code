using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkGenerator : MonoBehaviour
{
    public GameObject 힐링포션;
    public float respan1 = 5; //힐링포션이 나타나는 시간(리스폰 시간)
    float delta1 = 0;// 일정한 시간을 비교하기 위한 시간 변수


    void Update()
    {
        this.delta1 += Time.deltaTime; //this.delta = this.delta + Time.deltaTime;     
        if (this.delta1 > this.respan1)
        {
            this.delta1 = 0;
            GameObject copyDrink = Instantiate(힐링포션) as GameObject;
            int range1 = Random.Range(-18, 18); // Random.Range(최소값, 최대값)
            copyDrink.transform.position = new Vector3(range1, 11, 0);
        }
    }
}


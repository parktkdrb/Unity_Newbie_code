using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject 짭폭탄;
    public float respan = 0.5f; //짭폭탄이 나타나는 시간(리스폰 시간)
    float delta = 0;// 일정한 시간을 비교하기 위한 시간 변수
    public GameObject 힐링포션;
    float respan1 = 3; //힐링포션이 나타나는 시간(리스폰 시간)
    float delta1 = 0;// 일정한 시간을 비교하기 위한 시간 변수

    void Update()
    {
        this.delta += Time.deltaTime; //this.delta = this.delta + Time.deltaTime;     
        if(this.delta > this.respan)
        {
            this.delta = 0;
            GameObject copyBomb = Instantiate(짭폭탄) as GameObject;
            int range = Random.Range(-18, 18); // Random.Range(최소값, 최대값)
            copyBomb.transform.position = new Vector3(range, 11, 0);

        }
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

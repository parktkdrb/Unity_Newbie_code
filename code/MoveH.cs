using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 1.0f; //속도값, 이 변수는 퍼블릭이기 때문에 인스펙ㄷ터에서 변경이 가능하다.
 

    // Update is called once per frame
    void FixedUpdate()// 매 프레임마다 계속 실행한다.(일정시간마다)
    {
        this.transform.Translate(speed / 50, 0, 0); // 수평이동(+x축 방향으로 이동)
    }
}

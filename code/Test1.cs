using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public float speed = 5.0f; // public(공개 선언), 데이터형(int(정수), float(실수)), 변수이름 speed 그리고 변수값 5.0f
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed, 0, 0);
    }
}
 
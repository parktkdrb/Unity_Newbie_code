using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public float speed = 5.0f; // public(���� ����), ��������(int(����), float(�Ǽ�)), �����̸� speed �׸��� ������ 5.0f
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
 
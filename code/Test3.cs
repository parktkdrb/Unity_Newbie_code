using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() // 1 ~ 60 FPS
    {
        
    }
    private void FixedUpdate() // 50FPS
    {
        this.transform.Translate(-0.1f, 0, 0);
    }
}

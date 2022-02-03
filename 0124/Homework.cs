using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public float move_Speed = 1.0f; 
    float x_Speed = 0; 
    float y_Speed = 0; 
    bool leftFlag = false; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        x_Speed = 0;
        y_Speed = 0;
        if (Input.GetKey("right"))
        {
            x_Speed = move_Speed;
            leftFlag = false; 
        }

        if (Input.GetKey("left"))
        {
            x_Speed = -move_Speed;
            leftFlag = true;
        }

        if (Input.GetKey("up"))
        {
            y_Speed = move_Speed;
        }

        if (Input.GetKey("down"))
        {
            y_Speed = -move_Speed;
        }

    }

    private void FixedUpdate() 
    {
        this.transform.Translate(x_Speed, y_Speed, 0); 
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        
    }

}

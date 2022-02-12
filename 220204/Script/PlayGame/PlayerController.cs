using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float move = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-move, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(move, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, move, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -move, 0);
        }
        //캐릭터가 화면 밖을 나갔을떄 특정 Y좌표 밑으로 갔을때 게임 종료
        
            if (transform.position.y < -12f) // 카메라화면 밖의 좌표 지정
            {
            SceneManager.LoadScene("EndScene");
        }
    }

}

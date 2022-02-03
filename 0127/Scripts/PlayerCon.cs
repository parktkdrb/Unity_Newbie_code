using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float Speed = 0; // 변수 선언
    Vector2 startPos; // 2차원좌표의 벡터값(x,y) 3차원좌표의 벡터값(x,y,z)
    //Vector2는 2차원좌표값을 갖습니다.(x,y), Vetor3(x,y,z)
    Vector2 endpos; // 마우스를 눌렀다 떼었을때의 위치값이 들어갈 변수
    public float 분모값 = 1000.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0))//마우스 왼쪽버튼을 누르면 
        {
            this.startPos = Input.mousePosition; // 마우스버튼으로 눌렀을때의 위치값(x,y)
        }
        else if(Input.GetMouseButtonUp(0)) {
            Vector2 endPos = Input.mousePosition; // 마우스버튼으로 눌렀다가 떼었을때의 위치값(x,y)
            float length = (this.endpos.x - this.startPos.x); // 마지막 좌표값 - 처음 좌표값을 빼줍니다.
            this.Speed = length / 분모값;

            GetComponent<AudioSource>().Play();
        } 
        transform.Translate(this.Speed, 0, 0);//이동 x+방향
        this.Speed *= 0.98f;//감속

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour // 클래스 이름은 스크립트 파일이름과 같아야 한다.
{
    // Start is called before the first frame update
    void Start() // 매번 프레임이 갱신되어도 스타트 메소드 안에 있는 내용은 한번만 실행한다.
    {
        this.transform.Translate(10f, 0, 0); // 이 스크립트가 속해있는 게임 오브젝트의 트랜스폼컴포넌트를 이동시킨다. Trnaslate(x, y, z)

    }

    // Update is called once per frame
    void Update() // 매 프레임마다 계속적으로 갱신(추가)가 되는 메소드로 계속적으로 실행한다.
    {
        
    }
}

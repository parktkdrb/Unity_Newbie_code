using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {

        this.hpGauge = GameObject.Find("HP");
    }

    public void DecreaseHp()//HP 감수함수를 새로 만듦.
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        this.GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    public void IncreaseHp() // HP 증가 함수를 새로 만듦.
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
    void Update()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount == 0)
        {
                SceneManager.LoadScene("EndScene");
        }
    }
}

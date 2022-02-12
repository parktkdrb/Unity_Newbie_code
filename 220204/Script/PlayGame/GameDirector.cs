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

    public void DecreaseHp()//HP �����Լ��� ���� ����.
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        this.GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    public void IncreaseHp() // HP ���� �Լ��� ���� ����.
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

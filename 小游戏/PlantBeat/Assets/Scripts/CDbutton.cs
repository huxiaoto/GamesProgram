using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CDbutton : MonoBehaviour {
    public float cd = 2f;
    public float cd1 = 4f;
    private float spendtime = 0;
    private float spendtime1 = 0;
    private Image peashootcard;
    private Image sunflowercard;
    private bool IsStart = false;
    private bool IsStart1 = false;
    // Use this for initialization
    void Start()
    {
        peashootcard = GameObject.Find("PeashootCard").GetComponent<Image>();
        sunflowercard = GameObject.Find("SunflowerCard").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsStart == true)
        {
            Click.Iscd = true;
            spendtime += Time.deltaTime;
            peashootcard.fillAmount = (cd - spendtime) / cd;
            if (spendtime >= cd && GameManager.sunflower>= 100)
            {
                peashootcard.fillAmount = 1;
                spendtime = 0;
                IsStart = false;
                Click.Iscd = false;
            }
        }

        if (IsStart1 == true)
        {
            Click.Iscd1 = true;
            spendtime1 += Time.deltaTime;
            sunflowercard.fillAmount = (cd1 - spendtime1) / cd1;
            if (spendtime1 >= cd1 && GameManager.sunflower >= 125)
            {
                sunflowercard.fillAmount = 1;
                spendtime1 = 0;
                IsStart1 = false;
                Click.Iscd1 = false;
            }
        }
    }
    public void ButtonOnClick()
    {
        IsStart = true;

    }
    public void ButtonOnClick1()
    {
        IsStart1 = true;
    }

}

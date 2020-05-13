using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameSetting : MonoBehaviour {
    public GameObject Firstpanel;
    public GameObject Secondpanel;
    private void Start()
    {
        first();
    }
    public void first()
    {
        Firstpanel.SetActive(true);
        Secondpanel.SetActive(false);
    }
    public void second()
    {
        Firstpanel.SetActive(false);
        Secondpanel.SetActive(true);
    }
    public void ReturnButton()
    {
        first();
    }
}

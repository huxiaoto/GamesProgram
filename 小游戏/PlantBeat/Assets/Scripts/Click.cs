using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    public static bool Isclick;
    public GameObject plant;
    public static bool Isexist;
    public static bool Iscd;
    public static bool Iscd1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void click1()
    {   
        if (Iscd==true||GameManager.sunflower < 100)
        {
            return;
        }
        else
        {
            Isclick = true;
            GameManager.sunflower -= 100;
            plant = Resources.Load<GameObject>("Prefabs/PeaShooter");
            Net.plants = plant;
        }
    }
    public void click2()
    {    
        if (Iscd1==true||GameManager.sunflower < 125)
        {
            return;
        }
        else
        {
            Isclick = true;
            GameManager.sunflower -= 125;
            plant = Resources.Load<GameObject>("Prefabs/Twinsunflower");
            Net.plants = plant;
        }
    }
}

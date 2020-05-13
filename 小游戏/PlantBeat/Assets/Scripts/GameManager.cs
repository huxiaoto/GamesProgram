using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public List<GameObject> birthplaceList = new List<GameObject>();
    public GameObject zombie;
    GameObject zombieParent;
    int indexRow;
    int zombieNum = 0;
    public int sumZombieNUM;
    //public static float money = 125;
    public Text SunText;
    public static int sunflower = 125;
    float time;
    void Start()
    {
        //初始化钱
        //setMoney(money);
        zombie = Resources.Load<GameObject>("Prefabs/Zombie");
    }

    // Update is called once per frame
    void Update()
    {
        SunText.text = " " + sunflower;
        time += Time.deltaTime;       
        if (zombieNum < sumZombieNUM)
        {
            if (time >3)
            {
                time = 0;
                //随机出列表的索引
                indexRow = Random.Range(0, birthplaceList.Count);
                //根据索引从列表中取出出生点
                GameObject birthplace = birthplaceList[indexRow];
                //克隆僵尸对象并且把对象设置成和出生点一样的父物体
                GameObject zombieClone = (GameObject)GameObject.Instantiate(zombie, birthplace.transform);
                //设置位置
                zombieClone.transform.localPosition = birthplace.transform.position;
                zombieClone.transform.localScale = Vector3.one;
                zombieNum++;
            }
        }
    }

    /// <summary>
    /// 点击太阳事件
    /// </summary>
    /*public void ClickSunEvent(GameObject sun)
    {
        Destroy(sun);
        money += 50;
        setMoney(money);
    }*/

    public static void setMoney(float value)
    {
        //GameObject.Find("MoneyBG/Money").GetComponent<UILabel>().text = value.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Gameover").SetActive(true);
    }
}

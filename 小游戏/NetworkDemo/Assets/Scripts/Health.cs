using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : NetworkBehaviour {
    public float health = 100;
    public Slider healthSlider;
	// Use this for initialization
	void Start () {
        if (isLocalPlayer)
            healthSlider = GameObject.Find("hSlider").GetComponent<Slider>();
	}
    [ClientRpc]
    void Rpchealth(float serverhealth)
    {
        health = serverhealth;
    }
	public void GetDamage(float attack)
    {
        health -= attack;
        Rpchealth(health);   
    }
    [ClientRpc]
    void Rpcroad()
    {
        SceneManager.LoadScene("StartMenu");//客户端执行
    }
    [Command]
    void Cmdroad()
    {
        SceneManager.LoadScene("StartMenu");//服务端执行
    }
    void road()
    {
        Cmdroad();
    }
    /*[ClientRpc]
    void Rpcload()
    {
        SceneManager.LoadScene("Victory");//客户端执行
    }
    [Command]
    void Cmdload()
    {
        SceneManager.LoadScene("Defeat");//服务端执行
    }*/
    // Update is called once per frame
    void Update () {
        if (isLocalPlayer)
        healthSlider.value = health / 100.0f;
        if (isServer)
        {
            if(health<=0)
            {
                Destroy(gameObject);
                    Rpcroad();
                    road();   
            }
        }
	}
}

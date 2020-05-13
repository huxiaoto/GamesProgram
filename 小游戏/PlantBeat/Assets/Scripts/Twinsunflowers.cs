using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinsunflowers : MonoBehaviour {
    public GameObject twinsunflowers;
    public static int hp =200;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D other)
    {   
        if(other.tag=="enemy")
        {
            hp--;
            if (hp <= 0)
            {
                destroy();
            }  
        }
    }
    public void destroy()
    {
        Destroy(gameObject);
    }
}

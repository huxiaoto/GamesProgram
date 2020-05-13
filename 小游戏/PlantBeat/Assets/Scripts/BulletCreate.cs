using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour {
    private float time=1f;
    public GameObject PeaBolt;//子弹
    private bool Istouch;
	// Use this for initialization
	void Start () {
		
	}	
	// Update is called once per frame
	void Update () {
        //if (Istouch)
        //{
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 1f;

                {
                    Instantiate(PeaBolt, transform.position, Quaternion.identity);//实例化子弹   
                }
                //Invoke("trigger", 10);
            }
        //}
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="enemy")
        {
           Istouch = true;
        }
    }
    private void trigger()
    {
        Istouch = false;
    }
}

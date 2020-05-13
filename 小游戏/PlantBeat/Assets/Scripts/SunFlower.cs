using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour {
    public GameObject sunShine1;
    public float time = 12f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if(time<=0)
        {
            createsun();
            time = 12f;
        }
	}
    private void createsun()
    {
        Instantiate(sunShine1,transform.position,Quaternion.identity);
    }
}

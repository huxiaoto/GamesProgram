using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySun : MonoBehaviour {
    private float destroyTime = 4f;
    public GameObject sunShine1;
    private float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time>=destroyTime)
        {
            Destroy(gameObject);
            time = 0f;
        }
	}
}

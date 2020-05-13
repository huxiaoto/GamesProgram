using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombie : MonoBehaviour {
    private float destroyTime=4f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

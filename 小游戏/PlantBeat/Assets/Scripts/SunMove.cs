using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMove : MonoBehaviour {
    public GameObject sunShine;
    private float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {    
       //transform.Translate(Vector2.down * speed * Time.deltaTime);    
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y<0.75)
        {
            Destroy(gameObject);
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour {
    public Transform target;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime*5);
           // transform.position = target.position + offset;
        }    
	}
}

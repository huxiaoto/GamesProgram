using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Bullet : NetworkBehaviour {
    private float moveSpeed =5;
	// Use this for initialization
	void Start () {
       Destroy(gameObject, 5);
	}
    void OnCollisionEnter(Collision other)
     {
         if(other.collider)
         {
            if(isServer)
             {
                if(other.collider.tag=="Player")
                 {
                    other.collider.GetComponent<Health>().GetDamage(20);
                 }
               Destroy(gameObject);
             }
         }
     }
    // Update is called once per frame
    void Update () {
		if(isServer)
        {
            transform.Translate(new Vector3(0,0,moveSpeed) * Time.deltaTime);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaBoltMove : MonoBehaviour {
    public float speed;
    public GameObject peaBolt;
	// Use this for initialization
	void Start () {
      
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Plane")
        { return; }
        if(other.tag=="enemy")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
       peaBolt.gameObject.transform.position += peaBolt.gameObject.transform.right * speed * Time.deltaTime;
       if(transform.position.x>6.2f)
       {
          Destroy(this.gameObject);
       }
    }
}

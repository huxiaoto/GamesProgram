using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchSunFlower : MonoBehaviour {
    public GameObject sunshine;
    private bool Istouch;
    private float time = 4f;
	// Use this for initialization
	void Start () {

    }
    private void OnMouseOver()
    {
        Istouch = true;
        GameManager.sunflower += 25;
    }
    // Update is called once per frame
    void Update () {
        if(Istouch)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y+0.5f);                                 
        }
        else 
        {
            Destroy(gameObject, time);
        }
		
	}
}

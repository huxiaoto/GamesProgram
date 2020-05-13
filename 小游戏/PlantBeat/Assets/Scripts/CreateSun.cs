using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSun : MonoBehaviour {
    public GameObject sunShine;
    private float creatTime = 10f;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        creatTime -= Time.deltaTime;
        if (creatTime<=0)    
        {
            creatTime = 10f;
            create();
        }
    }  
  public void create()
    {
        sunShine.transform.position = new Vector2(Random.Range(-3.5f, 2f), Random.Range(3.42f, 3.45f));
        Instantiate(sunShine, sunShine.transform.position, Quaternion.identity);      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour {
    public static GameObject plants=null;
    private bool IsExist;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {   
        if(IsExist==true)
        {
            return;
        }
        else if(Click.Isclick)
        {   
            if(plants==null)
            {
                return;
            }
            if (plants != null)
            {
                Instantiate(plants, transform.position, Quaternion.identity);
                Click.Isclick = false;
                plants = null;
                IsExist = true;
            }
        }    
    }
}

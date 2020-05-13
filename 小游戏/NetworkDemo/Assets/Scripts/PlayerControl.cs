using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;
public class PlayerControl : NetworkBehaviour{
    private Rigidbody Rbody;
    public GameObject bullet;
    public GameObject shields;
    private Transform m_Transform;
	// Use this for initialization
	void Start () {
        Rbody = GetComponent<Rigidbody>();
        GameObject.Find("IP").GetComponent<Text>().text = "IP:"+Network.player.ipAddress;
        if(isLocalPlayer)
        {
            //GameObject.Find("Main Camera").GetComponent<CameraFallow>().target = gameObject.transform;
            //GameObject.Find("Main Camera").GetComponent<CameraFallow>().transform.parent= gameObject.transform;
            GameObject.Find("MyCamera").GetComponent<AutoCam>().m_Target= gameObject.transform;
        }
        m_Transform =gameObject.GetComponent<Transform>();
    }
    [Command]
    void Cmdmove(float h,float v,float x)
    {
        transform.Translate(Vector3.right * h * 5 * Time.deltaTime);
        //主角前后移动  
        transform.Translate(Vector3.forward * v * 5* Time.deltaTime);
      /* Vector3 dir = new Vector3(h, 0, v);
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
            Rbody.velocity = dir * 3;       
        }*/
        m_Transform.Rotate(Vector3.up,x);//控制镜头左右移动
    }
   /* [ClientRpc]
    void RpcaddCamera()
    {
        GameObject.Find("MyCamera").GetComponent<AutoCam>().transform.parent = gameObject.transform;
    }
    void addCamera()
    {
        RpcaddCamera();
    }*/
    [Command]
    void Cmdshield()
    {
        GameObject capsule;
        capsule = Instantiate(shields, transform.position + transform.forward * 1.5f, transform.rotation);
        NetworkServer.Spawn(capsule);
    }
    void shield()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Cmdshield();
        }
    }
    [Command]
    void Cmdshoot()
    {
        GameObject bolt;
        bolt = Instantiate(bullet,transform.position + transform.forward*2,transform.rotation);
        NetworkServer.Spawn(bolt);
    }
    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            AudioManager.instance.PlayShoot();
            Cmdshoot();
        }  
    }
	// Update is called once per frame
	void Update () {
        if(isLocalPlayer)
        {
            shoot();
            move();
            shield();
           // addCamera();
        }      
	}
    void move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Mouse X");
        //m_Transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));//控制镜头左右移动
        Cmdmove(h,v,x);
    }
}

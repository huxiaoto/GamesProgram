using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalk : MonoBehaviour {
    public float speed;
    public Rigidbody2D Rbody;
    private Animator Ani;
    public  int hp = 10;
	void Start () {
        Rbody = GetComponent<Rigidbody2D>();
        Ani = GetComponent<Animator>();
    }
    void Update () {    
          Invoke("walk",1);         
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="Plant")
        {
            Ani.SetBool("Iseat", true);
            speed = 0.05f;
            if(Twinsunflowers.hp<=0||PeaShooter.hp<=0)
            {
              Ani.SetBool("Iseat", false);
              speed = 0.2f;
              Invoke("change", 2);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="peabolt")
        {
            hp--;
            if (hp <= 0)
            {
                Ani.SetBool("Isdeath", true);
                speed = 0;
                Destroy(gameObject, 1);
            }
        }
    }
    private void walk()
    {
        Rbody.velocity = -Vector2.right * speed;
    }
    private void change()
    {
        Twinsunflowers.hp = 200;
        PeaShooter.hp = 120;
    }
}

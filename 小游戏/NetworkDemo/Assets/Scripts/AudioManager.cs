using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager instance;
    public AudioClip shoot;
    public AudioSource player;
    // Use this for initialization
    void Start()
    {
        instance = this;
        player = GetComponent<AudioSource>();
    }
    public void PlayShoot()
    {
        player.PlayOneShot(shoot);
    }
}

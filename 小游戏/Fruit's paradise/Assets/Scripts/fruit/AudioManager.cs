using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioClip amazing;
    public AudioClip unbelievable;
    public AudioClip exchange;
    public AudioClip great;
    public static AudioManager instance;
    private AudioSource player;
	// Use this for initialization
	void Start () {
        instance = this;
        player = GetComponent<AudioSource>();
	}
	public void playAmazing()
    {
        player.PlayOneShot(amazing);
    }
    public void playExchange()
    {
        player.PlayOneShot(exchange);
    }
    public void playGreat()
    {
        player.PlayOneShot(great);
    }
    public void playUnbelievable()
    {
        player.PlayOneShot(unbelievable);
    }
}

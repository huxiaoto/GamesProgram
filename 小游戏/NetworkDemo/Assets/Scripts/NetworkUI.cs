using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class NetworkUI : MonoBehaviour{
    // Use this for initialization
    void Start () {
      OfflineUiSet();
      //first();
    }
    void OfflineUiSet()
    {
        GameObject.Find("Create").GetComponent<Button>().onClick.AddListener(StartHost);
        GameObject.Find("Link").GetComponent<Button>().onClick.AddListener(StartClient);
    }
    void OnlineUI()
    {
        GameObject.Find("Break").GetComponent<Button>().onClick.AddListener(Stop);
    }
	public void StartHost()
    {
        NetworkManager.singleton.networkAddress = GameObject.Find("IP").GetComponent<InputField>().text;
        NetworkManager.singleton.StartHost();
    }
    public void StartClient()
    {
        NetworkManager.singleton.StartClient();
    }
    public void Stop()
    {
        NetworkManager.singleton.StopHost();
    }
    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("Loaded");
        if(level==0)
        {
            OfflineUiSet();
        }
        else
        {
            OnlineUI();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}

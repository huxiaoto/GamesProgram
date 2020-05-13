using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public GameObject [] PrefabsArray;
    public int IntRowNumber = 5;//当前场景行数量
    public float floatColumnsSpace = 1F;//棋盘列间距
    public float floatChessScale = 1F;//棋子大小
    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

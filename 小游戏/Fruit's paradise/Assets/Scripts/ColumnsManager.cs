using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsManager : MonoBehaviour {
    public static ColumnsManager Instance;
    internal Columns[] colArray = new Columns[8];
    public void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
		for(int i=0;i<colArray.Length;i++)
        {
            GameObject newObj = new GameObject();
            colArray[i] = newObj.AddComponent<Columns>();
            newObj.transform.parent = this.transform;//确立父子关系
            newObj.name = "Columns_" + i;//给列起名字
            colArray[i].IntCurrentColumnsNumber = i;//给列起编号数字
        }
	}
    /// <summary>
    /// 分配邻居
    /// </summary>
	internal void AssignNeighbor()
    {
        for(int i=0;i<colArray.Length;i++)
        {
            colArray[i].AssignNeighbor();//每一列分配邻居
        }
    }
}

using System.Collections;
using System.Collections.Generic;//泛型集合命名空间
using UnityEngine;
using UnityEngine.UI;
public class Columns : MonoBehaviour {
    public int IntCurrentColumnsNumber = -999;
    internal List<Chess> liChessArray = new List<Chess>();//当前列包含的“棋子”集合
	// Use this for initialization
	void Start () {
		for(int row=0;row<GameManager.Instance.IntRowNumber;row++)
        {
            GameObject prefabsObj = GameManager.Instance.PrefabsArray[Random.Range(0, 6)];//得到预设
            GameObject cloneObj= Instantiate(prefabsObj, new Vector3(IntCurrentColumnsNumber*GameManager.Instance.floatColumnsSpace, -row, prefabsObj.transform.position.z), Quaternion.identity);//克隆预设
            cloneObj.transform.parent = this.transform;//父子对象关系
            cloneObj.transform.localScale = new Vector3(GameManager.Instance.floatChessScale, GameManager.Instance.floatChessScale, GameManager.Instance.floatChessScale);
            liChessArray.Add(cloneObj.GetComponent<Chess>());//把克隆的棋子存入集合
        }
	}
    /// <summary>
    /// 分配邻居
    /// </summary>
	internal void AssignNeighbor()
    {
        for(int row=0;row<liChessArray.Count;row++)
        {
            //左
            if(IntCurrentColumnsNumber==0)
            {
                liChessArray[row].chessNeighbor[0] = null;
            }
            else
            {
                liChessArray[row].chessNeighbor[0] = ColumnsManager.Instance.colArray[IntCurrentColumnsNumber - 1].liChessArray[row];
            }
            //右
            if(IntCurrentColumnsNumber==ColumnsManager.Instance.colArray.Length-1)
            {
                liChessArray[row].chessNeighbor[1] = null;
            }
            else
            {
                liChessArray[row].chessNeighbor[1] = ColumnsManager.Instance.colArray[IntCurrentColumnsNumber + 1].liChessArray[row];
            }
            //上
            if(row==0)
            {
                liChessArray[row].chessNeighbor[2] = null;
            }
            else
            {
                liChessArray[row].chessNeighbor[2] = liChessArray[row - 1];
            }
            //下
            if(row==liChessArray.Count-1)
            {
                liChessArray[row].chessNeighbor[3] = null;
            }
            else
            {
                liChessArray[row].chessNeighbor[3] = liChessArray[row + 1];
            }
        }

    }
}

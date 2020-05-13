using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessOperation : MonoBehaviour {
    public static ChessOperation Instance;
    public void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
        Invoke("AssignNeighbor", 0.5f);
        Invoke("Test", 1f);
	}
	//棋盘分配邻居
    internal void AssignNeighbor()
    {
        ColumnsManager.Instance.AssignNeighbor();//列管理器分配邻居
        //对每一个棋子，由定义的数组转换成8个邻居字符串
        AssginNeighborEveryChess();
    }
    /// <summary>
    /// 对每一个棋子，由定义的数组转换成8个邻居字符串
    /// </summary>
    private void AssginNeighborEveryChess()
    {
        for (int col = 0; col < ColumnsManager.Instance.colArray.Length; col++)
        {
            for (int row = 0; row < ColumnsManager.Instance.colArray[col].liChessArray.Count; row++)
            {
                ColumnsManager.Instance.colArray[col].liChessArray[row].AssignNeighbor();
            }
        }
    }
    //测试方法
    public void Test()
    {
        for (int col = 0; col < ColumnsManager.Instance.colArray.Length; col++)
        {
            print(string.Format("col={0}",col));
            for (int row = 0; row < ColumnsManager.Instance.colArray[col].liChessArray.Count; row++)
            {
                print(string.Format("row={0}", row));
                ColumnsManager.Instance.colArray[col].liChessArray[row].TestAssignNeighbor();
            }
        }
    }
}

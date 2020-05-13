using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chess : MonoBehaviour {
    public Chess[] chessNeighbor = new Chess[4];//定义每个棋子的邻居(定义左/右/上/下“邻居”，分别用下表0，1，2，3表示)
    internal string strNeighborLeft1 = "Left1";
    internal string strNeighborLeft2 = "Left2";
    internal string strNeighborRight1 = "Right1";
    internal string strNeighborRight2 = "Right2";
    internal string strNeighborTop1 = "Top1";
    internal string strNeighborTop2 = "Top2";
    internal string strNeighborDown1 = "Down1";
    internal string strNeighborDown2 = "Down2";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 分配邻居
    /// </summary>
    internal void AssignNeighbor()
    {
        //参数判断
        if (chessNeighbor == null||chessNeighbor.Length==0)
        {
            Debug.LogError(string.Format("[Chess.cs/AssignNeighbor()] 参数非法，请检查"));
        }
        //左
        if(chessNeighbor[0])
        {
            strNeighborLeft1 = chessNeighbor[0].name;
            if(chessNeighbor[0].chessNeighbor[0])
            {
                strNeighborLeft2 = chessNeighbor[0].chessNeighbor[0].name;
            }     
        }
        //右
        if (chessNeighbor[1])
        {
            strNeighborRight1 = chessNeighbor[1].name;
            if (chessNeighbor[1].chessNeighbor[1])
            {
                strNeighborRight2 = chessNeighbor[1].chessNeighbor[1].name;
            }
        }
        //上
        if (chessNeighbor[2])
        {
            strNeighborTop1 = chessNeighbor[2].name;
            if (chessNeighbor[2].chessNeighbor[2])
            {
                strNeighborTop2 = chessNeighbor[2].chessNeighbor[2].name;
            }
        }
        //下
        if (chessNeighbor[3])
        {
            strNeighborDown1 = chessNeighbor[3].name;
            if (chessNeighbor[3].chessNeighbor[3])
            {
                strNeighborDown2 = chessNeighbor[3].chessNeighbor[3].name;
            }
        }
    }
    //测试方法
    public void TestAssignNeighbor()
    {
        print("");
        print("");
        print("strNeighborLeft1="+strNeighborLeft1);
        print("strNeighborLeft2="+strNeighborLeft2);
        print("strNeighborRight1=" + strNeighborRight1);
        print("strNeighborRight2=" + strNeighborRight2);
        print("strNeighborTop1=" + strNeighborTop1);
        print("strNeighborTop2=" + strNeighborTop2);
        print("strNeighborDown1=" + strNeighborDown1);
        print("strNeighborDown2=" + strNeighborDown2);
    }
}

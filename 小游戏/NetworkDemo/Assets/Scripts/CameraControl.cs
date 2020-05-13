using UnityEngine;
using System.Collections;
/*任务：控制摄像机视野的放大和缩小，望远镜功能
 
* 原理：放大视野：就是减小摄像机的垂直视野范围（减小FOV值）
 
*       缩小视野：就是增加摄像机的垂直视野范围（增加FOV值）
 
*/
public class CameraControl : MonoBehaviour
{
    public int magnify = 2;//放大倍数
    public float magnifySpeed = 50f;//放大速度
    public float shrinkSpeed = 50f;//缩小速度
    public Camera m_camera;//指定的摄像机
    private float initFov;
    private Transform m_Transform;//摄像机垂直视野的范围的初始值
    //public Transform playerTrs;
    //public Vector3 deltaPos;
    void Start()
    {
        initFov = m_camera.fieldOfView;//设置视野的初始值
        m_Transform = gameObject.GetComponent<Transform>();
        //deltaPos = new Vector3(0, 5, -5);
        //Vector3 pos = playerTrs.TransformDirection(deltaPos);
        //transform.position = playerTrs.position + pos;
        //transform.LookAt(playerTrs.position);
    }
    void Update()

    {
        /*float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");//鼠标垂直
        if (x != 0 || y != 0)
        {
            transform.RotateAround(playerTrs.position, transform.right, -y);
            transform.RotateAround(playerTrs.position, playerTrs.up, x);
        }*/
        if (Input.GetKey(KeyCode.Mouse1))//按下右键放大视野
        {
            MagnifyView();         
        }
        else //否则缩小视野（带原有视野）
        {
            ShrinkView();
        }
        m_Transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y"));//控制镜头上下移动
        Vector3 rotation = transform.localEulerAngles;
        rotation.y = 0;
        rotation.z = 0;
        transform.localEulerAngles = rotation;

    }
    /// <summary>
    /// 放大视野
    /// </summary>
     void MagnifyView()//放大视野就是，减小FOV的值
     {
        //如果现在FOV-下一帧的视野值，还大于原有视野值的一半，就继续减少视野值，放大视野
        if ((m_camera.fieldOfView - Time.deltaTime * magnifySpeed) >= (initFov / magnify))
        {
            m_camera.fieldOfView -= Time.deltaTime * magnifySpeed;
        }
        else//否则保持视野值到最小值
        {
            m_camera.fieldOfView = initFov / magnify;
        }
     }

    /// <summary>
    /// 缩小视野
    /// </summary>
     void ShrinkView()
     {
        //如果现在FOV+下一帧的视野值，还小于原有视野值的一半，就继续增减视野值，缩小视野
        if ((m_camera.fieldOfView + Time.deltaTime * magnifySpeed) <= initFov)
        {
            m_camera.fieldOfView += Time.deltaTime * shrinkSpeed;
        }
        else//否则保持视野值到初始垂直视野值
        {
            m_camera.fieldOfView = initFov;
        }
     }
}
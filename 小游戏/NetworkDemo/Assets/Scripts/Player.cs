using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Transform m_Transform;
    private float speed = 0.1f;
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        MoveControl();
    }

    void MoveControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Transform.Translate(Vector3.forward * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Transform.Translate(Vector3.back * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Transform.Translate(Vector3.left * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Transform.Translate(Vector3.right * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            m_Transform.Rotate(Vector3.up, -1.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            m_Transform.Rotate(Vector3.up, 1.0f);
        }
        m_Transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));//控制镜头左右移动
    }
}

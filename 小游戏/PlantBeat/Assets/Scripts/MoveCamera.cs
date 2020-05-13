using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveCamera : MonoBehaviour
{
    public AnimationCurve SlidingCurve = new AnimationCurve();
    public float duration = 1.0f;
    public float rightMoveEdge;
    public float leftMoveEdge;
    public float preViewTime;
    public static bool signal = false;

    private Vector3 cameraPosition;
    private Vector3 outLookPos = Vector3.zero;
    private Vector3 playerViewPos = Vector3.zero;

    void Start()
    {
        //取得摄像机的初始位置
        //初始化镜头右移的位置
        outLookPos = transform.position;
        outLookPos.x = rightMoveEdge;
        //初始化镜头左移的位置
        playerViewPos = transform.position;
        playerViewPos.x = leftMoveEdge;

        StartCoroutine(cameraMove());
    }

    void Update()
    {

    }

    IEnumerator cameraMove()
    {
        yield return StartCoroutine(HoldForAWhile(preViewTime));
        yield return StartCoroutine(cameraMoveRight());
        yield return StartCoroutine(HoldForAWhile(preViewTime));
        yield return StartCoroutine(cameraMoveLeft());
        signal = true;
    }

    IEnumerator cameraMoveRight()
    {
        float time = 0.0f;
        cameraPosition = transform.position;

        while (time <= duration)
        {
            float t = time / duration;
            transform.position = Vector3.Lerp(cameraPosition, outLookPos, SlidingCurve.Evaluate(t));
            time += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator cameraMoveLeft()
    {
        float time = 0.0f;
        cameraPosition = transform.position;

        while (time <= duration)
        {
            float t = time / duration;
            transform.position = Vector3.Lerp(cameraPosition, playerViewPos, SlidingCurve.Evaluate(t));
            time += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator HoldForAWhile(float preViewTime)
    {
        yield return new WaitForSeconds(preViewTime);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    // 目标
    public Transform Target;
    // 平滑时间
    public float SmoothTime = 0.5f;
    void Update()
    {
        // 定义一个三维向量 将当前物体的初始位置赋值给它
        Vector3 CurrentPosition = transform.position;
        // 将目标位置赋值给一个三维向量
        Vector3 TargetPosition = Target.position;
        // 实现平滑移动
        transform.position = Vector3.Lerp(CurrentPosition, TargetPosition, SmoothTime * Time.deltaTime);
    }
}

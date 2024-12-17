// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 实现功能：通过按下鼠标左键拖动屏幕上的3D物体对象
/// </summary>

public class ObjectMovement : MonoBehaviour
{
    // 判断当前物体是否正在被拖动
    private bool isDragging = false;
    // 记录鼠标与物体之间的距离 偏移量
    private Vector3 offset;
    void Update()
    {
        if (isDragging)
        {
            // 获取鼠标在屏幕空间上的位置坐标
            Vector3 mousePosition = Input.mousePosition;
            // 将鼠标的屏幕空间位置坐标转换为世界空间的位置坐标 考虑物体与相机在Z轴上差值
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));
            // 更新当前物体的位置
            transform.position = newPosition + offset;
        }
    }
    // 鼠标左键按下
    private void OnMouseDown()
    {
        // 获取鼠标在屏幕空间上的位置坐标
        Vector3 mousePosition = Input.mousePosition;
        // 将物体当前位置减去鼠标在世界空间的位置
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));
        // 表示当前物体正在被拖动
        isDragging = true;
    }
    // 鼠标左键抬起
    private void OnMouseUp()
    {
        // 表示当前物体没有被拖动
        isDragging = false;
    }
}

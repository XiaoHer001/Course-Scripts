// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastClick : MonoBehaviour
{
    // 定义一个全局变量用来指定可交互的图层
    public LayerMask TargetLayer;
    void Update()
    {
        // 监听鼠标左键是否被按下
        if (Input.GetMouseButtonDown(0))
        {
            // 从摄像机位置向鼠标位置发射一条射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // hit存储在射线检测过程中的碰撞信息
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, TargetLayer))
            {
                Renderer renderer = hit.collider.GetComponent<Renderer>();
                if (renderer != null)
                {
                    string ObjectName = hit.collider.gameObject.name;
                    switch (ObjectName)
                    {
                        case "Cube1":
                            renderer.material.color = Color.red;
                            break;
                        case "Cube2":
                            renderer.material.color = Color.blue;
                            break;
                        case "Cube3":
                            renderer.material.color = Color.green;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

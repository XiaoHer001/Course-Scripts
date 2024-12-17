// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheCubeAni : MonoBehaviour
{
    // 获取动画控制器组件
    private Animator Cube_Ani;
    void Start()
    {
        // 获取自身(Cube)身上的Animator组件
        Cube_Ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 如果按下E键 切换为CubeTwo动画
        if (Input.GetKeyDown(KeyCode.E))
        {
            Cube_Ani.SetBool("IsTwo", true);
        }
        // 如果按下Q键 切换回Cube动画
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cube_Ani.SetBool("IsTwo", false);
        }
    }
}

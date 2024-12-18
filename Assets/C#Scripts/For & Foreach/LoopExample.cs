// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: For与Foreach循环的基本用法及区别
// 编码作者: 小贺儿
// 修改时间: 2024年12月07日 10:28:36
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在LoopExample同名物体对象上
// ================================================

public class LoopExample : MonoBehaviour
{
    string[] names = { "小张", "小王", "小李" };
    void Start()
    {
        // For循环: For(初始化;条件;迭代){循环体}
        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log("当前索引: " + i);
        // }
        // Foreach循环: Foreach(类型 变量名 in 集合){循环体}
        foreach (string name in names)
        {
            Debug.Log("当前元素: " + name);
        }
    }
}
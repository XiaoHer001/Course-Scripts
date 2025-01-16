// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;

// ================================================
// 实现功能: 接口类
// 编码作者: 小贺儿
// 修改时间: 2025年01月16日 10:54:18
// 修改内容: 新建脚本
// 备注说明: 无需挂载
// ================================================

// 实现接口的类
public class Car : IDriveable
{
    public void Drive()
    {
        Debug.Log("The car is driving.");
    }

    public void Stop()
    {
        Debug.Log("The car has stopped.");
    }
}
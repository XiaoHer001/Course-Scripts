// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;

// ================================================
// 实现功能: 派生类
// 编码作者: 小贺儿
// 修改时间: 2025年01月16日 11:17:23
// 修改内容: 新建脚本
// 备注说明: 无需挂载
// ================================================

public class CarAbs : Vehicle
{
    // CarAbs类的构造函数调用了基类（子类）Vehicle的构造函数，通过base(name)名称。
    public CarAbs(string name) : base(name) { }

    // 实现抽象方法
    public override void Move()
    {
        Debug.Log(Name + " is moving.");
    }
}
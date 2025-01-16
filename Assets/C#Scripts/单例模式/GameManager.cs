// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;

// ================================================
// 实现功能: 调用单例对象中的指定方法
// 编码作者: 小贺儿
// 修改时间: 2025年01月13日 11:27:19
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在GameManager同名对象上
// ================================================

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // 调用普通单例MySingleton中的DoSomething方法
        MySingleton.Instance.DoSomething();
        // 调用MonoBehaviour单例中的StartGame方法
        MonoSingleton.Instance.StartGame();
    }
}
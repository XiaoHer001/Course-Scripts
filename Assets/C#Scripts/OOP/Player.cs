// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 定义一个玩家类 父类 装满宝物的箱子
/// </summary>
public class Player
{
    // 声明一个私有的字段 用于存储玩家的生命值 箱子里的宝物
    private int health;
    // 公共属性 用于访问和修改玩家的生命值 特定的口子
    public int Health
    {
        // 获取玩家当前的生命值 从箱子中拿取宝物
        get { return health; }
        // 设置玩家的生命值 同时确保这个生命值在0-100之间 往箱子中放入宝物
        set { health = Mathf.Clamp(value, 0, 100); }
    }
    // 构造函数 用来在初始化玩家对象时设置默认的生命值 100
    public Player()
    {
        health = 100;
    }
    // 公共方法 用来减少玩家生命值并输出当前的生命值
    public void TakeDamage(int damage)
    {
        // 减少生命值
        Health -= damage;
        // 输出
        Debug.Log("玩家生命值: " + Health);
    }
}
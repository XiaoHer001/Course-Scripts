// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 定义一个Boss敌人类 继承自敌人类
/// </summary>
public class BossEnemy : Enemy
{
    // 构造函数 初始化Boss的类型
    public BossEnemy() : base("Boss")
    {

    }
    // 覆盖父类 Enemy类中的Attack方法 用于隐藏这个父类的方法而不是重写
    public new void Attack()
    {
        Debug.Log("Boss向玩家发出猛烈攻击！！");
    }
}

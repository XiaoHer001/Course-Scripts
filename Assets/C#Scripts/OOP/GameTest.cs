// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 具体测试脚本
/// </summary>
public class GameTest : MonoBehaviour
{
    void Start()
    {
        // 创建玩家对象并测试受伤
        Player player = new Player();
        player.TakeDamage(20);

        // 创建敌人对象并测试攻击和受伤
        Enemy enemy = new Enemy("Goblin");
        enemy.Attack();
        enemy.TakeDamage(30);

        // 创建Boss敌人对象并测试攻击和受伤
        BossEnemy bossEnemy = new BossEnemy();
        bossEnemy.Attack();
        bossEnemy.TakeDamage(50);
    }
}

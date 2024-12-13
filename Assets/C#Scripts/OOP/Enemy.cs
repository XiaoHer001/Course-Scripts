using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 定义一个敌人类 继承自玩家类
/// </summary>
public class Enemy : Player
{
    // 自己特有的属性 表示敌人的类型
    public string EnemyType { get; set; }
    // 构造函数 初始化敌人的类型
    public Enemy(string enemyType)
    {
        EnemyType = enemyType;
    }
    // 自己的攻击方法
    public void Attack()
    {
        Debug.Log(EnemyType + "被攻击啦！");
    }
}

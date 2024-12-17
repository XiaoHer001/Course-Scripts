// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 实现功能：控制玩家移动和交互
/// 编码作者：小贺儿
/// 修改时间：2024年11月14日11:40:03
/// 修改内容：新建脚本
/// 备注：测试专用
/// </summary>

public class PlayerControl : MonoBehaviour
{
    // 玩家的最大生命值 float h;
    private const float MAX_HEALTH = 100f;
    // 玩家当前的生命值
    private float _currentHealth;
    // 玩家移动速度
    //private float _playerSpeed = 5f;
    public float CurrentHealth
    {
        get { return _currentHealth; }
        set { _currentHealth = Mathf.Clamp(value, 0, MAX_HEALTH); }
    }
    // Start is called before the first frame update
    void Start()
    {
        // 初始化玩家
        InitializePlayer();
    }

    // Update is called once per frame
    void Update()
    {

    }
    #region 玩家初始化
    /// <summary>
    /// 玩家初始化
    /// </summary>
    private void InitializePlayer()
    {
        // 生命值为最大
        _currentHealth = MAX_HEALTH;
    }
    #endregion
    /// <summary>
    /// 玩家伤害
    /// </summary>
    /// <param name="damage">受到的伤害</param>
    private void TakeDamage(float damage)
    {

    }
}

// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;

// ================================================
// 实现功能: 订阅PlayerScoredEvent事件（简化）
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 16:44:41
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

public class EventSubscriber : MonoBehaviour
{
    public EventSimple publisher;
    private void Start()
    {
        if (publisher != null)
        {
            publisher.PlayerScoredEvent += OnPlayerScored;
        }
    }
    private void OnDestroy()
    {
        if (publisher != null)
        {
            publisher.PlayerScoredEvent -= OnPlayerScored;
        }
    }
    private void OnPlayerScored(int score)
    {
        Debug.Log("订阅者收到分数：" + score);
    }
}
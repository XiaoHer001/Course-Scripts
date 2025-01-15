using System;
using UnityEngine;

// ================================================
// 实现功能: 发布PlayerScoredEvent事件（简化）
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 16:43:46
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

public class EventSimple : MonoBehaviour
{
    // 除了使用自定义委托类型，也可以使用内置的 Action 和 Action<T>
    public event Action<int> PlayerScoredEvent;
    private int score = 0;
    public void PlayerScored()
    {
        score += 10;
        Debug.Log("玩家得分：" + score);
        // 使用 ?.Invoke 简化触发
        PlayerScoredEvent?.Invoke(score);
    }
}
using UnityEngine;

// ================================================
// 实现功能: ScriptableObject数据
// 编码作者: 小贺儿
// 修改时间: 2025年01月19日 17:00:47
// 修改内容: 新建脚本
// 备注说明: 无需挂载
// ================================================

// 为ScriptableObject 类在 Unity 编辑器的Assets > Create 菜单中添加一个自定义选项
[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    // 玩家名称
    public string playerName = "DefaultPlayer";
    // 玩家分数
    public int score = 0;

    /// <summary>
    /// 增加分数
    /// </summary>
    public void AddScore(int amount)
    {
        score += amount;
    }

    /// <summary>
    /// 重置玩家数据
    /// </summary>
    public void ResetStats()
    {
        playerName = "DefaultPlayer";
        score = 0;
    }
}
using UnityEngine;

// ================================================
// 实现功能: ScriptableObject数据持久化测试
// 编码作者: 小贺儿
// 修改时间: 2025年01月19日 17:02:14
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在PlayerStatsManager同名物体上
// ================================================

public class PlayerStatsManager : MonoBehaviour
{
    public PlayerStats playerStats; // 指定的 ScriptableObject 实例

    private void Start()
    {
        // 显示初始状态
        Debug.Log($"玩家名称: {playerStats.playerName}, 初始分数: {playerStats.score}");
    }

    private void Update()
    {
        // 按键控制功能
        if (Input.GetKeyDown(KeyCode.A)) // 增加分数
        {
            playerStats.AddScore(10);
            Debug.Log($"玩家 {playerStats.playerName} 当前分数: {playerStats.score}");
        }

        if (Input.GetKeyDown(KeyCode.R)) // 重置数据
        {
            playerStats.ResetStats();
            Debug.Log($"玩家数据已重置，当前名称: {playerStats.playerName}, 分数: {playerStats.score}");
        }
    }
}
using UnityEngine;

// ================================================
// 实现功能: 发布OnScoreChanged事件类
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 16:18:38
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在ScoreManager同名物体对象上
// ================================================

// 发布者类
public class ScoreManager : MonoBehaviour
{
    // 定义一个委托
    public delegate void ScoreChanged(int newScore);
    // 声明一个事件
    public event ScoreChanged OnScoreChanged;
    private int score;
    public void AddScore(int points)
    {
        score += points;
        // 触发事件
        OnScoreChanged?.Invoke(score);
    }
}
using UnityEngine;

// ================================================
// 实现功能: 测试增加分数
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 16:26:05
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在GameController同名物体对象上
// ================================================

public class GameController : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void Start()
    {
        // 测试增加分数
        // 输出: New Score: 10
        scoreManager.AddScore(10);
        // 输出: New Score: 30
        scoreManager.AddScore(20);
    }
}
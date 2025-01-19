using UnityEngine;

// ================================================
// 实现功能: PlayerPrefs数据持久化测试
// 编码作者: 小贺儿
// 修改时间: 2025年01月19日 13:38:51
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在PlayerPrefsSave同名脚本上
// ================================================

public class PlayerPrefsSave : MonoBehaviour
{
    void Start()
    {
        // 读取数据
        int score = PlayerPrefs.GetInt("HighScore");
        string playerName = PlayerPrefs.GetString("PlayerName");
        // 在控制台输出
        Debug.Log($"score = {score} , playerName = {playerName}");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 保存数据
            PlayerPrefs.SetInt("HighScore", 100);
            PlayerPrefs.SetString("PlayerName", "Player1");
            PlayerPrefs.Save();
            // 保存提示
            Debug.Log("保存成功!");
        }
    }
}
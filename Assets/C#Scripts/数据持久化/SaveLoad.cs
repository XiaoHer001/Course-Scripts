using System.IO;
using UnityEngine;

// ================================================
// 实现功能: 数据持久化测试
// 编码作者: 小贺儿
// 修改时间: 2025年01月19日 16:33:03
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在SaveLoad同名物体对象上
// ================================================

public class SaveLoad : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 保存数据
            Save();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 加载数据
            Load();
        }
    }
    /// <summary>
    /// 保存数据到文件
    /// </summary>
    private void Save()
    {
        // 创建一个新的玩家数据对象
        GameData data = new GameData();
        // 设置玩家名称
        data.playerName = "Player1";
        // 设置玩家分数
        data.score = 100;
        // 将数据对象转换为JSON字符串
        string json = JsonUtility.ToJson(data);
        // 将JSON字符串写入文件（文件路径为持久化数据路径/savefile.json）
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("数据已保存到: " + Application.persistentDataPath + "/savefile.json");
    }

    /// <summary>
    /// 从文件加载数据
    /// </summary>
    private void Load()
    {
        // 检查保存文件是否存在
        if (File.Exists(Application.persistentDataPath + "/savefile.json"))
        {
            // 从文件中读取JSON字符串
            string json = File.ReadAllText(Application.persistentDataPath + "/savefile.json");
            // 将JSON字符串转换回数据对象
            GameData data = JsonUtility.FromJson<GameData>(json);
            // 输出加载的数据
            Debug.Log("玩家名称: " + data.playerName + " 分数: " + data.score);
        }
        else
        {
            Debug.LogWarning("存档文件不存在！");
        }
    }
}
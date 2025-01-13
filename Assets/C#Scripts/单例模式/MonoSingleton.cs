using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: MonoBehaviour单例
// 编码作者: 小贺儿
// 修改时间: 2025年01月13日 11:33:26
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在MonoSingleton同名物体对象上
// ================================================

public class MonoSingleton : MonoBehaviour
{
    // 静态实例
    public static MonoSingleton Instance { get; private set; }
    // Unity 的 Awake 方法
    private void Awake()
    {
        // 如果实例已经存在，并且不是当前对象，则销毁当前对象
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        // 设置为单例实例
        Instance = this;
        // 如果需要跨场景保持实例，启用以下代码
        DontDestroyOnLoad(gameObject);
    }
    // 示例方法
    public void StartGame()
    {
        Debug.Log("Game Started!");
    }
}
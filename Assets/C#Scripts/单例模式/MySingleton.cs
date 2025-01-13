using UnityEngine;

// ================================================
// 实现功能: 普通类单例
// 编码作者: 小贺儿
// 修改时间: 2025年01月13日 11:25:05
// 修改内容: 新建脚本
// 备注说明: 无需挂载脚本
// ================================================

public class MySingleton
{
    private static MySingleton _instance;

    // 私有构造函数，防止外部实例化
    private MySingleton() { }

    // 公共静态属性，返回唯一实例
    public static MySingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }
            return _instance;
        }
    }

    // 示例方法
    public void DoSomething()
    {
        Debug.Log("MySingleton is working!");
    }
}
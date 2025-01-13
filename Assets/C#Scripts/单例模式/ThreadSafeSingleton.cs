using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: 线程安全的单例模式类。
// 编码作者: 小贺儿
// 修改时间: 2025年01月13日 11:47:08
// 修改内容: 新建脚本
// 备注说明: 无需挂载脚本
// ================================================

public class ThreadSafeSingleton
{
    // 单例实例，用于保存唯一的对象
    private static ThreadSafeSingleton _instance;
    // 锁对象，用于确保多线程访问时的线程安全
    private static readonly object _lock = new object();
    // 私有构造函数，防止通过外部代码直接实例化该类
    private ThreadSafeSingleton() { }
    // 单例访问点，获取唯一实例
    public static ThreadSafeSingleton Instance
    {
        get
        {
            // 使用锁来确保线程安全
            lock (_lock)
            {
                // 如果实例尚未创建，则创建一个新的实例
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                }
                // 返回唯一实例
                return _instance;
            }
        }
    }
}
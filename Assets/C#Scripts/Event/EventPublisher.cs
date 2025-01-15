using UnityEngine;

// ================================================
// 实现功能: 事件简单示例代码
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 14:21:16
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在EventPublisher同名物体对象上
// ================================================

public class EventPublisher : MonoBehaviour
{
    // 声明一个委托类型
    public delegate void MyEventHandler(string message);
    // 基于委托声明事件
    public event MyEventHandler OnEventOccurred;
    private void Start()
    {
        // 订阅事件
        OnEventOccurred += PrintMessage;
        // 触发事件
        TriggerEvent();
    }
    void TriggerEvent()
    {
        // 使用空条件操作符（?.）安全地调用事件。
        // 如果没有任何方法订阅该事件，调用将不会发生。
        OnEventOccurred?.Invoke("Hello, Event!");
    }
    void PrintMessage(string message)
    {
        Debug.Log(message);
    }
}
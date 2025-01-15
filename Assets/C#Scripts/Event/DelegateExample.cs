using UnityEngine;

// ================================================
// 实现功能: 委托简单示例代码
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 13:25:51
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在DelegateExample同名物体对象上
// ================================================

public class DelegateExample : MonoBehaviour
{
    // 声明委托
    public delegate void MyDelegateStr(string message);
    public delegate void MyDelegateInt(int number);
    void Start()
    {
        // 将方法赋值给委托
        MyDelegateStr myDelegateStr = PrintMessage;
        MyDelegateInt myDelegateInt = PrintNumber;
        // 调用委托 输出 Hello World
        myDelegateStr("Hello, World!");
        // 输出 Number: 10
        myDelegateInt(10);
        
        // 也可以将另一个方法添加到委托
        myDelegateInt += DoubleNumber;
        // 调用委托，调用的顺序是从上到下
        // 输出 Number: 5
        // 输出 Double: 10
        myDelegateInt(5);
    }
    void PrintMessage(string message)
    {
        Debug.Log(message);
    }
    // 符合委托签名的方法
    void PrintNumber(int num)
    {
        Debug.Log("Number: " + num);
    }

    // 另一个符合委托签名的方法
    void DoubleNumber(int num)
    {
        Debug.Log("Double: " + (num * 2));
    }
}
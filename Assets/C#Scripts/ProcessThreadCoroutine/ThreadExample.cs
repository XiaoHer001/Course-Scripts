using System.Threading;
using UnityEngine;

public class ThreadExample : MonoBehaviour
{
    void Start()
    {
        // 创建并启动一个新线程
        Thread newThread = new Thread(PrintNumbers);
        newThread.Start(); // 启动线程
    }

    void PrintNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            Thread.Sleep(500); // 模拟一些延时操作
        }
    }
}

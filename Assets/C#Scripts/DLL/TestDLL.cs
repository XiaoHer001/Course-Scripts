using UnityEngine;
using UnityLibrary;

// ================================================
// 实现功能: 测试UnityLibrary.dll
// 编码作者: 小贺儿
// 修改时间: 2025年01月18日 10:05:54
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在TestDLL同名物体对象上
// ================================================

public class TestDLL : MonoBehaviour
{
    void Start()
    {
        int sum = MathUtils.Add(5, 3);
        Debug.Log($"Sum: {sum}");

        int product = MathUtils.Multiply(5, 3);
        Debug.Log($"Product: {product}");
    }
}
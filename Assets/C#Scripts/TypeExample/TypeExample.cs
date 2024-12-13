using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: C#值类型与引用类型的区别
// 编码作者: 小贺儿
// 修改时间: 2024年12月13日 15:30:21
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

public class TypeExample : MonoBehaviour
{
    class MyClass
    {
        public int value;
    }
    void Start()
    {
        // 值类型
        // int a = 10;
        // b是a的数据副本 修改b的值不会影响a
        // int b = a;
        // b = 20;
        // Debug.Log("a = " + a);
        // Debug.Log("b = " + b);
        // 引用类型
        MyClass objA = new MyClass();
        objA.value = 10;
        // objB引用的是和objA相同的对象 修改B的Value值会影响到A的Value值
        MyClass objB = objA;
        objB.value = 20;
        Debug.Log("A value = " + objA.value);
        Debug.Log("B value = " + objB.value);
    }
    void Update()
    {
        
    }
}
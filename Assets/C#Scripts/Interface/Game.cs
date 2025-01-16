// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;

// ================================================
// 实现功能: 定义并使用接口、定义抽象类并调用方法
// 编码作者: 小贺儿
// 修改时间: 2025年01月16日 10:49:35
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在Game同名物体对象上
// ================================================

// 定义一个接口
public interface IDriveable
{
    // 定义一个没有实现的Drive方法
    void Drive();
    // 定义一个没有实现的Stop方法
    void Stop();
}

// 定义一个抽象类
public abstract class Vehicle
{
    // 字段
    public string Name { get; set; }

    // 构造函数
    public Vehicle(string name)
    {
        Name = name;
    }

    // 定义一个普通方法
    public void Honk()
    {
        Debug.Log("Beep! Beep!");
    }

    // 定义一个抽象方法
    public abstract void Move();
}

public class Game : MonoBehaviour
{
    void Start()
    {
        // 使用接口类型来引用对象
        //IDriveable myCar = new Car();
        // 输出 The car is driving.
        //myCar.Drive();
        // 输出 The car has stopped.
        //myCar.Stop();

        // 定义了一个Vehicle类型的变量myCar，并实例化为Car类型，名称为"Toyota"
        Vehicle myCar = new CarAbs("Toyota");
        // 输出 Beep! Beep!
        myCar.Honk();
        // 输出 Toyota is moving.
        myCar.Move();
    }
}
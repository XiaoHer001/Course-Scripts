// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;
using System.Diagnostics;
using System;

public class ProcessExample : MonoBehaviour
{
    void Start()
    {
        try
        {
            // 创建一个新的进程对象
            Process process = new Process();

            // 设置要启动的程序的文件名
            process.StartInfo.FileName = "notepad.exe";

            // 启动进程
            process.Start();
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogError("启动进程出错: " + e.Message);
        }
    }
}
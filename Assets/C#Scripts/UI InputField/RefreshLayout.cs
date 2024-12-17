// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 实现功能：刷新UI布局
/// </summary>

public class RefreshLayout : MonoBehaviour
{
    // 声明输入字段
    public TMP_InputField TextInput;
    void Start()
    {
        // 为输入字段添加监听事件
        TextInput.onValueChanged.AddListener(Refresh);
    }
    // 刷新布局的方法
    private void Refresh(string text)
    {
        // 开启协程
        StartCoroutine(ActivateInput());
    }
    IEnumerator ActivateInput()
    {
        // 通过禁用再启用输入字段实现刷新
        TextInput.gameObject.SetActive(false);
        TextInput.gameObject.SetActive(true);
        // 暂停协程 等待下一帧再继续执行下方的代码
        yield return null;
        // 激活输入字段并获取焦点
        TextInput.ActivateInputField();
    }
}

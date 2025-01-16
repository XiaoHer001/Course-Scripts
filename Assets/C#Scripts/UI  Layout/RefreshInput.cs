// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RefreshInput : MonoBehaviour
{
    // public TMP_InputField TextInput;

    // 刷新方法，可从外部调用以触发输入框的刷新操作
    public void Refresh()
    {
        // 将输入框的游戏对象设置为不可见
        //TextInput.gameObject.SetActive(false);
        // 接着将输入框的游戏对象设置为可见
        //TextInput.gameObject.SetActive(true);
        // 激活输入框，使其获得焦点并准备接收用户输入
        //TextInput.ActivateInputField();
        //StartCoroutine(ReactivateInputField());
    }

    // 私有协程方法，用于重新激活输入框
    private IEnumerator ReactivateInputField()
    {
        
        // 暂停协程，等待下一帧继续
        yield return null;
        
    }
}

// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTheScene : MonoBehaviour
{
    void Update()
    {
        // 当我们按下键盘上的ESC键时 退出程序
        // 如果在编辑器下
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
            // 如果打包以后
#else
        Application.Quit();
#endif
        }
    }
}

// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicToggleController : MonoBehaviour
{
    // 声明一个Toggle组件
    public Toggle MusicToggle;
    // 声明一个音频源组件
    public AudioSource MusicAudio;
    void Start()
    {
        // 对Toggle组件初始化
        MusicToggle.isOn = MusicAudio.mute;
        // 为Toggle添加监听事件
        MusicToggle.onValueChanged.AddListener(ToggleMusic);
    }
    private void ToggleMusic(bool isOn)
    {
        // 通过Toggle组件控制音频的静音和恢复声音
        //MusicAudio.mute = isOn;
        // 三目运算符（条件运算符）
        // 条件表达式 ？ 表达式1 : 表达式2
        MusicAudio.mute = isOn ? true : false;
    }
}

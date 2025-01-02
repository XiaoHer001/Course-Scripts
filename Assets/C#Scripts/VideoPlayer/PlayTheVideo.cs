using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

// ================================================
// 实现功能: 通过键盘的空格键控制视频的播放和暂停
// 编码作者: 小贺儿
// 修改时间: 2025年01月02日 11:59:32
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

public class PlayTheVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    void Update()
    {
        // 如果按下空格键
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 如果视频正在播放则暂停
            if(videoPlayer.isPlaying)
            {
                // 暂停视频
                videoPlayer.Pause();
            }
            else
            {
                // 从暂停位置继续播放视频
                videoPlayer.Play();
            }
        }
    }
}
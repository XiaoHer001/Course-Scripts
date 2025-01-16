// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using UnityEngine;

// ================================================
// 实现功能: 订阅OnScoreChanged事件类
// 编码作者: 小贺儿
// 修改时间: 2025年01月15日 16:24:31
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在ScoreDisplay同名物体对象上
// ================================================

// 订阅者类
public class ScoreDisplay : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnEnable()
    {
        // 订阅事件
        scoreManager.OnScoreChanged += UpdateScoreDisplay;
    }
    private void OnDisable()
    {
        // 取消订阅事件
        scoreManager.OnScoreChanged -= UpdateScoreDisplay;
    }
    private void UpdateScoreDisplay(int newScore)
    {
        Debug.Log("New Score: " + newScore);
    }
}
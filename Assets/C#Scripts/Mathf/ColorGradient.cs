// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ColorGradient : MonoBehaviour
{
    // 立方体的MeshRenderer
    public MeshRenderer CubeMeshRenderer;
    // 初始的颜色 红色
    public Color StartColor = Color.red;
    // 最终渐变到的颜色 白色
    public Color EndColor = Color.white;
    // 渐变过渡的时间 持续时间
    public float SmoothTime = 0.5f;
    // 记录时间的流逝
    private float TimeElapsed = 0f;
    private float a, b, t;
    void Update()
    {
        // 时间累加
        TimeElapsed += Time.deltaTime;
        float T = TimeElapsed / SmoothTime;
        CubeMeshRenderer.material.color = Color.Lerp(StartColor, EndColor, T);

        float LerpValue = Mathf.Lerp(0, 10, 0.5f);
        Debug.Log("插值结果为：" + LerpValue);
    }
}

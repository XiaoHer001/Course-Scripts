// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleExample : MonoBehaviour
{
    // 第一类：诞生期
    private void Awake()
    {
        Debug.Log("Awake Is Called");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable Is Called");
    }
    private void Start()
    {
        Debug.Log("Start Is Called");
    }

    // 第二类：起效期
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Is Called");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 将当前物体对象销毁
            Destroy(gameObject);
        }
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate Is Called");
    }

    // 第三类：消退期
    private void OnDisable()
    {
        Debug.Log("OnDisable Is Called");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy Is Called");
    }
}

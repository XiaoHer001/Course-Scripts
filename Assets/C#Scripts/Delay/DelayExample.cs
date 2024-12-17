// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayExample : MonoBehaviour
{
    void Start()
    {
        // 协程
        //StartCoroutine("DelayFunction");
        // Invoke
        //Invoke("DelayMethod",2.0f);
        InvokeRepeating("RepeatedDelayMethod",2.0f,3.0f);
    }
    IEnumerator DelayFunction()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log("延迟2秒执行");
    }
    private void DelayMethod()
    {
        Debug.Log("延迟2秒执行");
    }
    private void RepeatedDelayMethod()
    {
        Debug.Log("首次延迟2秒执行，之后，每间隔3秒执行一次");
    }
}

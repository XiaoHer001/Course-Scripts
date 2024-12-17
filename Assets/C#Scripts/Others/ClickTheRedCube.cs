// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTheRedCube : MonoBehaviour
{
    public Image Background;
    private void OnMouseDown()
    {
        //print("鼠标按下");
        // 点击红色立方体 3秒后出现UI
        // 开启协程
        // StartCoroutine("Appear");
        // 错误的方法 没有这么写的
        StartCoroutine(Appear());
        Invoke("Stop", 4.0f);
    }
    private void Stop()
    {
        StopCoroutine(Appear());
        //StopAllCoroutines();
        print("终止了这个协程");
    }
    IEnumerator Appear()
    {
        // 延迟3秒后
        yield return new WaitForSeconds(3.0f);
        // 显示UI
        Background.gameObject.SetActive(true);
        // 采用它给的方法 终止协程 StopCoroutine 这个方法适用于在协程之外终止某一个协程 在协程里面无效
        //StopCoroutine("Appear");
        // 在协程里面终止协程的方法
        //yield break;
        // 终止所有协程 放在协程里面和外面 都有效果
        //StopAllCoroutines();
        yield return new WaitForSeconds(2.0f);
        print("没有终止这个协程");
    }
    private void OnMouseOver()
    {
        //print("鼠标悬停");
    }
    private void OnMouseEnter()
    {
        //print("鼠标进入碰撞体");
    }
    private void OnMouseExit()
    {
        //print("鼠标离开碰撞体");
    }
    private void OnMouseUp()
    {
        //print("鼠标按下后松开");
    }
    private void OnMouseDrag()
    {
        //print("鼠标长按每三帧调用一次");
    }





    // 开启协程
    //  1  StartCoroutine("Appear");
    //  2  StartCoroutine(Appear());

    // 终止单一协程
    //  在协程外终止协程
    //   1  StopCoroutine("Appear");
    //   2  StopCoroutine(Appear()); 有问题，无法终止

    //  在协程里面终止协程
    //   yield break;
    //  在协程里外均可以
    //   终止所有协程
    //   StopAllCoroutines();























}

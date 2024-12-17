// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeCollider : MonoBehaviour
{
    // 碰撞物体双方都不是/都没勾选是触发器 不让它穿过去
    private void OnCollisionEnter(Collision collision)
    {
        //print("接触碰撞体/刚体");
    }
    private void OnCollisionStay(Collision collision)
    {
        //print("处在碰撞体/刚体之中");
    }
    private void OnCollisionExit(Collision collision)
    {
        //print("离开碰撞体/刚体");
    }
    // 碰撞双方必须有一个是/勾选了是触发器 让它穿过去
    private void OnTriggerEnter(Collider other)
    {
        print("接触碰撞体/触发器");
    }
    private void OnTriggerStay(Collider other)
    {
        print("处在碰撞体/触发器之中");
    }
    private void OnTriggerExit(Collider other)
    {
        print("离开碰撞体/触发器");
    }
}

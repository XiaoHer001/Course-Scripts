// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionProbeUpdate : MonoBehaviour
{
    public ReflectionProbe reflectionProbe;
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            reflectionProbe.RenderProbe();
        }
    }
}

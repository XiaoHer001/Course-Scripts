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

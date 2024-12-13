using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 取绝对值 -15的绝对值 正确答案为15
        float NegativeValue = -15f;
        float AbsValue = Mathf.Abs(NegativeValue);
        Debug.Log("-15的绝对值为：" + AbsValue);

        // 求最大最小值 7 12 
        float a = 7f;
        float b = 12f;
        float MaxValue = Mathf.Max(a, b);
        float MinValue = Mathf.Min(a, b);
        Debug.Log("最大值为：" + MaxValue);
        Debug.Log("最小值为：" + MinValue);

        // 限制值在指定的范围内 15 5-10
        float NumValue = 1;
        float ClampValue = Mathf.Clamp(NumValue, 5f, 10f);
        Debug.Log("限制值为：" + ClampValue);

        // 幂运算 二的三次方 8
        float BaseValue = 2;
        float PowValue = 3;
        float PowerValue = Mathf.Pow(BaseValue, PowValue);
        Debug.Log("幂运算的值为：" + PowerValue);

        // 平方根 25 5
        float Num = 25f;
        float SqrtValue = Mathf.Sqrt(Num);
        Debug.Log("平方根的值为：" + SqrtValue);

        // 角度值和弧度值的互相转换 角度值为60 弧度值为三分之π
        double Degree = 60f;
        double Radian = Math.PI / 3;
        double DegToRad = Mathf.Deg2Rad * Degree;
        double RadToDeg = Mathf.Rad2Deg * Radian;
        Debug.Log("60度的弧度值为：" + DegToRad);
        Debug.Log("三分之π的角度值为：" + RadToDeg);

        // 插值

    }

    // Update is called once per frame
    void Update()
    {

    }
}

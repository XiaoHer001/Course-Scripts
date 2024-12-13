using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeMove : MonoBehaviour
{
    void Update()
    {
        // 控制红色立方体移动
        // 获取键盘输入的水平方向的数值 X轴的参数
        float h = Input.GetAxis("Horizontal");
        // 获取键盘输入的垂直方向的数值 Z轴参数
        float v = Input.GetAxis("Vertical");
        // 移动 使红色立方体每一帧都向输入的新坐标按一定的速度进行移动
        transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * 4);
    }
}

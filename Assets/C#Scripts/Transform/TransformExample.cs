using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: Transform常用属性及方法
// 编码作者: 小贺儿
// 修改时间: 2025年01月08日 15:35:02
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在TransformExample同名物体对象上
// ================================================

public class TransformExample : MonoBehaviour
{
    private Transform target;
    private Transform newParentTransform;
    private float speed = 30f;

    void Start()
    {
        // 将对象移动到世界坐标 (0, 1, 0)
        transform.position = new Vector3(0, 1, 0);
        // 设置对象在父对象本地坐标中的位置
        transform.localPosition = new Vector3(1, 0, 0);
        // 设置对象绕Y轴旋转90度
        transform.rotation = Quaternion.Euler(0, 90, 0);
        // 将物体旋转到绕Y轴90度的位置
        transform.eulerAngles = new Vector3(0, 90, 0);

        // 从欧拉角转换为四元数
        Vector3 eulerAngles = new Vector3(30f, 45f, 60f);
        Quaternion quaternion = Quaternion.Euler(eulerAngles);
        // 从四元数转换为欧拉角
        // Quaternion quaternion = Quaternion.Euler(30f, 45f, 60f);
        // Vector3 eulerAngles = quaternion.eulerAngles;

        // 设置本地旋转为45度
        transform.localRotation = Quaternion.Euler(0, 45, 0);
        // 将对象放大2倍
        transform.localScale = new Vector3(2, 2, 2);
        // 获取物体的上方向
        Vector3 up = transform.up;
        // 获取物体的右方向
        Vector3 right = transform.right;
        // 获取物体的前方向
        Vector3 forward = transform.forward;
        // 获取父对象
        Transform parentTransform = transform.parent;
        // 设置新的父对象
        transform.parent = null;
        // 获取子物体数量
        int count = transform.childCount;
        // 向前平移 5 单位
        transform.Translate(Vector3.forward * 5);
        // 在世界空间中向上平移 3 单位
        transform.Translate(Vector3.up * 3, Space.World);
        // 默认在本地坐标空间中绕Y轴旋转90度
        transform.Rotate(new Vector3(0, 90, 0));
        // 在世界坐标中旋转
        transform.Rotate(new Vector3(0, 90, 0), Space.World);
        // 让当前对象面向目标对象
        transform.LookAt(target, new Vector3(0, 1, 0));
        // 设置父物体
        transform.SetParent(parentTransform);
        // 设置父物体，并保持局部坐标不变
        transform.SetParent(newParentTransform, false);
        // 将所有子对象从当前对象中移除
        transform.DetachChildren();
        // 查找名为ChildName的子对象
        Transform child = transform.Find("ChildName");
        // 获取第一个子对象
        // Transform child = transform.GetChild(0);
    }
    private void Update()
    {
        // 围绕目标的世界位置，绕Y轴旋转，每秒旋转 speed 度
        // speed * Time.deltaTime 确保旋转是基于时间的，旋转速度不会因帧率不同而变化。
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        // 物体自身的中心点作为旋转中心，绕Y轴旋转
        transform.RotateAround(transform.position, Vector3.up, 1f);
    }
}
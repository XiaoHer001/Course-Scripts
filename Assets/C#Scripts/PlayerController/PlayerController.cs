// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 移动速度
    public float MoveSpeed = 5f;
    // 冲刺倍数
    public float SprintMultiplier = 2f;
    // 刚体组件
    private Rigidbody PlayerRb;
    // 鼠标灵敏度
    public float MouseLookSensity = 2f;
    // 标记鼠标右键是否被按下
    private bool IsRightMouseDown = false;
    // 鼠标垂直方向的旋转角度
    private float XRotation = 0f;
    // 鼠标最大的垂直旋转角度
    private float MaxMouseXAngle = 60f;
    private void Start()
    {
        // 获取当前物体上的刚体组件
        PlayerRb = GetComponent<Rigidbody>();
        // 解锁鼠标光标（默认的一个状态）
        Cursor.lockState = CursorLockMode.None;
        // 显示鼠标光标
        Cursor.visible = true;
    }
    private void FixedUpdate()
    {
        // 处理移动
        HandleMovement();
    }
    private void Update()
    {
        // 处理鼠标旋转视角
        HandleMouseLook();
    }
    private void HandleMovement()
    {
        // 获取一下移动速度 并赋值给一个局部变量
        float speed = MoveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed *= SprintMultiplier;
        }
        // 获取水平输入 移动量
        float MoveHorizontal = Input.GetAxisRaw("Horizontal");
        // 获取垂直输入 移动量
        float MoveVertical = Input.GetAxisRaw("Vertical");
        Vector3 Movement = transform.forward * MoveVertical + transform.right * MoveHorizontal;
        // 利用刚体移动
        PlayerRb.MovePosition(PlayerRb.position + Movement * speed * Time.deltaTime);
    }
    private void HandleMouseLook()
    {
        // 鼠标右键按下
        if (Input.GetMouseButtonDown(1))
        {
            IsRightMouseDown = true;
            // 锁定鼠标光标
            Cursor.lockState = CursorLockMode.Locked;
            // 隐藏鼠标光标
            Cursor.visible = false;
        }
        // 鼠标右键抬起
        if (Input.GetMouseButtonUp(1))
        {
            IsRightMouseDown = false;
            // 解锁鼠标光标
            Cursor.lockState = CursorLockMode.None;
            // 显示鼠标光标
            Cursor.visible = true;
        }
        // 旋转视角
        if (IsRightMouseDown)
        {
            // 获取鼠标的水平输入 移动量 并让用户自己调整旋转速度
            float MouseX = Input.GetAxisRaw("Mouse X") * MouseLookSensity;
            // 获取鼠标的垂直输入 移动量 并让用户自己调整旋转速度
            float MouseY = Input.GetAxisRaw("Mouse Y") * MouseLookSensity;
            // 水平旋转角色
            transform.Rotate(0f, MouseX, 0f);
            // 限制垂直方向的旋转角度
            XRotation -= MouseY;
            // 限制垂直旋转的角度 从-60到+60
            XRotation = Mathf.Clamp(XRotation, -MaxMouseXAngle, MaxMouseXAngle);
            // 将垂直旋转应用到相机上
            Camera.main.transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        }
    }
}

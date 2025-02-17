using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: 补全机器人对象身上用于控制机器人的Unity脚本
// 编码作者: 小贺儿
// 修改时间: 2025年02月17日 09:52:04
// 修改内容: 新建脚本
// 备注说明: 左键点击地面，机器人转向点击点方向并向该方向移动，在移动过程中，机器人会由待机动画状态过渡到行走动画状态，
// 停止移动则返回待机动画状态。机器人对象具有Transform、Animator、CharacterController等组件，isWalk是动画状态机中待机
// 动画和行走动画过渡的Bool类型条件参数。
// ================================================

public class RobotController : MonoBehaviour
{
    [Range(-1, 2)]
    public float sliderValue;
    CharacterController characterController;
    Animator animator;

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Ground"))
                {
                    if (Vector3.Distance(hit.point, this.transform.position) > 0.1f)
                    {
                        Vector3 step = Vector3.ClampMagnitude(hit.point - this.transform.position, 0.05f);
                        this.transform.LookAt(new Vector3(hit.point.x, 0.08f, hit.point.z));
                        animator.SetBool("isWalk", true);
                        characterController.Move(step);
                    }
                }
            }
        }
        else
        {
            animator.SetBool("isWalk", false);
        }
    }
}
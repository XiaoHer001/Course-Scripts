using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheCubeAni : MonoBehaviour
{
    // ��ȡ�������������
    private Animator Cube_Ani;
    void Start()
    {
        // ��ȡ����(Cube)���ϵ�Animator���
        Cube_Ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // �������E�� �л�ΪCubeTwo����
        if (Input.GetKeyDown(KeyCode.E))
        {
            Cube_Ani.SetBool("IsTwo", true);
        }
        // �������Q�� �л���Cube����
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cube_Ani.SetBool("IsTwo", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeMove : MonoBehaviour
{
    void Update()
    {
        // ���ƺ�ɫ�������ƶ�
        // ��ȡ���������ˮƽ�������ֵ X��Ĳ���
        float h = Input.GetAxis("Horizontal");
        // ��ȡ��������Ĵ�ֱ�������ֵ Z�����
        float v = Input.GetAxis("Vertical");
        // �ƶ� ʹ��ɫ������ÿһ֡��������������갴һ�����ٶȽ����ƶ�
        transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * 4);
    }
}

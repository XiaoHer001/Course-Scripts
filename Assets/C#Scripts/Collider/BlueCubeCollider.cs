using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeCollider : MonoBehaviour
{
    // ��ײ����˫��������/��û��ѡ�Ǵ����� ����������ȥ
    private void OnCollisionEnter(Collision collision)
    {
        //print("�Ӵ���ײ��/����");
    }
    private void OnCollisionStay(Collision collision)
    {
        //print("������ײ��/����֮��");
    }
    private void OnCollisionExit(Collision collision)
    {
        //print("�뿪��ײ��/����");
    }
    // ��ײ˫��������һ����/��ѡ���Ǵ����� ��������ȥ
    private void OnTriggerEnter(Collider other)
    {
        print("�Ӵ���ײ��/������");
    }
    private void OnTriggerStay(Collider other)
    {
        print("������ײ��/������֮��");
    }
    private void OnTriggerExit(Collider other)
    {
        print("�뿪��ײ��/������");
    }
}

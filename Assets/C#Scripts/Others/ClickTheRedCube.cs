using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTheRedCube : MonoBehaviour
{
    public Image Background;
    private void OnMouseDown()
    {
        //print("��갴��");
        // �����ɫ������ 3������UI
        // ����Э��
        // StartCoroutine("Appear");
        // ����ķ��� û����ôд��
        StartCoroutine(Appear());
        Invoke("Stop", 4.0f);
    }
    private void Stop()
    {
        StopCoroutine(Appear());
        //StopAllCoroutines();
        print("��ֹ�����Э��");
    }
    IEnumerator Appear()
    {
        // �ӳ�3���
        yield return new WaitForSeconds(3.0f);
        // ��ʾUI
        Background.gameObject.SetActive(true);
        // ���������ķ��� ��ֹЭ�� StopCoroutine ���������������Э��֮����ֹĳһ��Э�� ��Э��������Ч
        //StopCoroutine("Appear");
        // ��Э��������ֹЭ�̵ķ���
        //yield break;
        // ��ֹ����Э�� ����Э����������� ����Ч��
        //StopAllCoroutines();
        yield return new WaitForSeconds(2.0f);
        print("û����ֹ���Э��");
    }
    private void OnMouseOver()
    {
        //print("�����ͣ");
    }
    private void OnMouseEnter()
    {
        //print("��������ײ��");
    }
    private void OnMouseExit()
    {
        //print("����뿪��ײ��");
    }
    private void OnMouseUp()
    {
        //print("��갴�º��ɿ�");
    }
    private void OnMouseDrag()
    {
        //print("��곤��ÿ��֡����һ��");
    }





    // ����Э��
    //  1  StartCoroutine("Appear");
    //  2  StartCoroutine(Appear());

    // ��ֹ��һЭ��
    //  ��Э������ֹЭ��
    //   1  StopCoroutine("Appear");
    //   2  StopCoroutine(Appear()); �����⣬�޷���ֹ

    //  ��Э��������ֹЭ��
    //   yield break;
    //  ��Э�����������
    //   ��ֹ����Э��
    //   StopAllCoroutines();























}

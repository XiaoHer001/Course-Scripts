using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTheScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����ǰ��¼����ϵ�ESC��ʱ �˳�����
        // ����ڱ༭����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
            // �������Ժ�
#else
        Application.Quit();
#endif
        }
    }
}

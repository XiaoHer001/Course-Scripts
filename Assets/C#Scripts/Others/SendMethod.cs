using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����ǰ���Q��ʱ������Test�������ϵĽű�Test�е�
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(1);
        }
        // �����ǰ���E��ʱ��תFirst Course����
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(0);
        }
    }
}

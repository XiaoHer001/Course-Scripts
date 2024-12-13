using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendMethod : MonoBehaviour
{
    void Update()
    {
        // 当我们按下Q键时调用在Test空物体上的脚本Test中的
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(1);
        }
        // 当我们按下E键时跳转First Course场景
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(0);
        }
    }
}

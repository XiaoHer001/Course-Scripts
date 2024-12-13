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
        // 当我们按下键盘上的ESC键时 退出程序
        // 如果在编辑器下
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
            // 如果打包以后
#else
        Application.Quit();
#endif
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

// ================================================
// 实现功能: 同步加载场景
// 编码作者: 小贺儿
// 修改时间: 2025年01月08日 12:10:20
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在LoadSceneExample物体对象上
// ================================================

public class LoadSceneExample : MonoBehaviour
{
    private void Update()
    {
        // 按下1键时
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 同步加载到Scene01或0号场景(场景的名称或者索引)
            SceneManager.LoadScene("Scene01");
            // SceneManager.LoadScene(0);
            // SceneManager.LoadScene("Scene01", LoadSceneMode.Additive);
        }
        // 按下2键时
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 同步加载到Scene02或1号场景(场景的名称或者索引)
            SceneManager.LoadScene("Scene02");
            // SceneManager.LoadScene(1);
            // SceneManager.LoadScene("Scene02", LoadSceneMode.Additive);
        }
    }
}
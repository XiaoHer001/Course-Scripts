using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// ================================================
// 实现功能: 
// 编码作者: 小贺儿
// 修改时间: 2025年01月08日 12:36:43
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

public class LoadSceneAsyncExample : MonoBehaviour
{
    private void Update()
    {
        // 按下1键时
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 开始异步加载Scene01场景
            StartCoroutine(LoadScene("Scene01"));
        }
        // 按下2键时
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 开始异步加载Scene02场景
            StartCoroutine(LoadScene("Scene02"));
        }
    }
    private IEnumerator LoadScene(string SceneName)
    {
        // 异步加载场景
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneName);
        // 设置场景为非激活状态，直到加载完成
        asyncOperation.allowSceneActivation = false;
        // 检查加载进度
        while (!asyncOperation.isDone)
        {
            Debug.Log($"加载进度: {asyncOperation.progress * 100}%");
            // 当加载进度达到 90% 时，激活场景
            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
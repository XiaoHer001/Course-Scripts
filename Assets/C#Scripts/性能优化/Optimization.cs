using UnityEngine;

// ================================================
// 实现功能: GPU Instancing代码示例
// 编码作者: 小贺儿
// 修改时间: 2025年01月23日 11:43:16
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

public class Optimization : MonoBehaviour
{
    public MeshRenderer myRenderer;
    // 缓存组件（避免每次都调用GetComponent）
    private Transform cachedTransform;
    void Start()
    {
        // 降低物理更新频率
        Time.fixedDeltaTime = 0.02f; // 默认是0.02，可以适当增加

        // 启用 GPU Instancing 的材质
        Material material = myRenderer.material;
        material.enableInstancing = true;

        cachedTransform = transform;

        // 每秒更新一次
        InvokeRepeating("UpdateScore", 0, 1.0f);
    }
    void Update()
    {
        cachedTransform.position += Vector3.forward * Time.deltaTime;
    }
}
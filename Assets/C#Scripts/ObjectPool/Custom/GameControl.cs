using UnityEngine;

// ================================================
// 实现功能: 初始化对象池脚本
// 编码作者: 小贺儿
// 修改时间: 2025年01月17日 09:12:37
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在GamePool同名物体对象上
// ================================================

// 初始化对象池
public class GameControl : MonoBehaviour
{
    public ObjectPool objectPool;
    public GameObject bulletPrefab;

    void Start()
    {
        // 初始化一个名为 "Bullets" 的对象池，初始大小为10
        objectPool.CreatePool("Bullets", bulletPrefab, 10);
    }
}
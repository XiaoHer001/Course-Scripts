using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: 对象池通用示例
// 编码作者: 小贺儿
// 修改时间: 2025年01月17日 09:08:09
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在ObjectPool同名物体对象上
// ================================================

// 对象池管理器
public class ObjectPool : MonoBehaviour
{
    // 存储对象池的字典
    private Dictionary<string, Queue<GameObject>> poolDictionary = new Dictionary<string, Queue<GameObject>>();

    // 创建对象池
    public void CreatePool(string poolKey, GameObject prefab, int initialSize)
    {
        if (poolDictionary.ContainsKey(poolKey))
        {
            Debug.LogWarning($"对象池 {poolKey} 已经存在！");
            return;
        }

        Queue<GameObject> objectQueue = new Queue<GameObject>();

        for (int i = 0; i < initialSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            objectQueue.Enqueue(obj);
        }

        poolDictionary[poolKey] = objectQueue;
    }

    // 从对象池中获取对象
    public GameObject GetFromPool(string poolKey, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(poolKey))
        {
            Debug.LogError($"对象池 {poolKey} 不存在！");
            return null;
        }

        GameObject obj;

        if (poolDictionary[poolKey].Count > 0)
        {
            obj = poolDictionary[poolKey].Dequeue();
        }
        else
        {
            Debug.LogWarning($"对象池 {poolKey} 已空，实例化新的对象！");
            obj = Instantiate(poolDictionary[poolKey].Peek());
        }

        obj.SetActive(true);
        obj.transform.position = position;
        obj.transform.rotation = rotation;

        return obj;
    }

    // 将对象返回对象池
    public void ReturnToPool(string poolKey, GameObject obj)
    {
        if (!poolDictionary.ContainsKey(poolKey))
        {
            Debug.LogError($"对象池 {poolKey} 不存在！");
            Destroy(obj);
            return;
        }

        obj.SetActive(false);
        poolDictionary[poolKey].Enqueue(obj);
    }
}
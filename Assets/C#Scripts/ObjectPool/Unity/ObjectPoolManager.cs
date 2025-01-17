using UnityEngine;
using UnityEngine.Pool;

// ================================================
// 实现功能: 使用Unity自带的 ObjectPool<T> 类重构对象池脚本
// 编码作者: 小贺儿
// 修改时间: 2025年01月17日 09:44:47
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

// 对象池类
public class ObjectPoolManager : MonoBehaviour
{
    public GameObject bulletPrefab; // 子弹预制体
    public int initialSize = 10;    // 初始对象池大小
    public int maxSize = 20;        // 最大对象池大小

    private ObjectPool<GameObject> bulletPool; // 对象池

    void Awake()
    {
        // 初始化对象池
        bulletPool = new ObjectPool<GameObject>(
            createFunc: () => Instantiate(bulletPrefab),
            actionOnGet: obj => obj.SetActive(true),
            actionOnRelease: obj => obj.SetActive(false),
            actionOnDestroy: Destroy,
            collectionCheck: false,
            defaultCapacity: initialSize,
            maxSize: maxSize
        );
    }

    // 从对象池获取对象
    public GameObject GetBullet(Vector3 position, Quaternion rotation)
    {
        GameObject bullet = bulletPool.Get();
        bullet.transform.position = position;
        bullet.transform.rotation = rotation;
        return bullet;
    }

    // 将对象返回对象池
    public void ReturnBullet(GameObject bullet)
    {
        bulletPool.Release(bullet);
    }
}
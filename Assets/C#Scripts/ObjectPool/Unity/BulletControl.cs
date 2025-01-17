using System.Collections;
using UnityEngine;

// ================================================
// 实现功能: 使用Unity自带的 ObjectPool<T> 类重构发射子弹脚本
// 编码作者: 小贺儿
// 修改时间: 2025年01月17日 09:42:56
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在
// ================================================

// 子弹类
public class BulletControl : MonoBehaviour
{
    public ObjectPoolManager objectPoolManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 按下空格发射子弹
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        if (objectPoolManager == null)
        {
            Debug.LogError("ObjectPoolManager 未设置！");
            return;
        }

        // 获取子弹对象并设置初始位置和方向
        GameObject bullet = objectPoolManager.GetBullet(transform.position, Quaternion.identity);

        // 为子弹添加简单移动逻辑
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * 10f;
        }

        // 定时将子弹返回对象池
        StartCoroutine(ReturnBulletToPool(bullet, 2f));
    }

    private IEnumerator ReturnBulletToPool(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);

        // 返回子弹到对象池
        if (objectPoolManager != null)
        {
            objectPoolManager.ReturnBullet(bullet);
        }
    }
}
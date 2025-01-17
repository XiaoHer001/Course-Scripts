using System.Collections;
using UnityEngine;

// ================================================
// 实现功能: 使用对象池发射子弹
// 编码作者: 小贺儿
// 修改时间: 2025年01月17日 09:23:42
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在BulletController同名物体上
// ================================================

public class BulletController : MonoBehaviour
{
    public ObjectPool objectPool;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 从对象池获取子弹
            GameObject bullet = objectPool.GetFromPool("Bullets", transform.position, Quaternion.identity);

            // 给子弹添加简单的移动逻辑
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * 10f;

            // 返回对象池
            StartCoroutine(ReturnBulletToPool(bullet, 2f));
        }
    }

    private IEnumerator ReturnBulletToPool(GameObject bullet, float delay)
    {
        // 延迟2秒后将对象返回对象池
        yield return new WaitForSeconds(delay);
        objectPool.ReturnToPool("Bullets", bullet);
    }
}
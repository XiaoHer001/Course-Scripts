using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: 小地图
// 编码作者: 小贺儿
// 修改时间: 2024年12月24日 11:29:11
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在MiniMap同名物体上
// ================================================

public class MiniMap : MonoBehaviour
{
    // 玩家位置
    public Transform player;
    // 玩家图标
    public RectTransform playerIcon;
    // 缩放比例
    public float mapScale = 1f;
    void Update()
    {
        // 获取玩家在世界空间的坐标
        Vector3 worldPos = player.position;
        // 玩家图标的位置
        Vector2 mapPos = new Vector2(worldPos.x, worldPos.z) * mapScale;
        // 更新玩家图标在小地图上的位置
        playerIcon.anchoredPosition = mapPos;
        // 更新玩家图标的旋转角度
        playerIcon.rotation = Quaternion.Euler(0, 0, player.eulerAngles.y);
    }
}
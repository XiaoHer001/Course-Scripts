using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 实现功能：数组与列表
/// </summary>

public class ArrayAndListExample : MonoBehaviour
{
    // 定义和初始化
    // 数组 特点：1.长度固定（无法更改） 2.访问元素的速度比列表快 3.功能有限（存储和访问）
    // 4.结构简单（适合处理已知大小的数据集） 5.内存使用效率较高（固定的大小）
    int[] array = { 1, 2, 3, 4, 5 };
    // 列表 特点：1.长度可变（可添加删除元素） 2.访问速度稍慢（动态调整） 3.提供了丰富的方法（添加删除查找元素等）
    // 4.结构更加复杂（适合处理需要动态调整大小的数据集） 5.可能需要额外的分配内存（动态调整）
    List<int> list = new List<int> { 1, 2, 3, 4, 5 };
    // Start is called before the first frame update
    void Start()
    {
        // 常用方法
        // 数组
        // 通过索引来访问元素 索引值 从0开始的 0 1 2 3 4
        //Debug.Log(array[2]);
        // 获取数组的长度
        //Debug.Log(array.Length);
        // 遍历输出数组中的所有元素
        //TraverseArray();
        // 列表
        // 通过索引来访问元素 索引值 从0开始的 0 1 2 3 4
        //Debug.Log(list[2]);
        // 添加元素 将一个元素加到列表的末尾
        //list.Add(6);
        // 插入元素 在指定的索引处插入一个元素
        //list.Insert(2,7);
        // 删除元素 删除列表中的指定元素
        //list.Remove(3);
        // 删除元素 删除列表中指定索引值对应的元素
        //list.RemoveAt(2);
        // 获取元素的数量
        //Debug.Log(list.Count);
        // 清除列表中所有元素
        //list.Clear();
        // 判断列表中是否包含指定元素
        Debug.Log(list.Contains(6));
        //TraverseList();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // 遍历数组
    private void TraverseArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }
    // 遍历列表
    private void TraverseList()
    {
        foreach (var item in list)
        {
            Debug.Log(item);
        }
    }
}

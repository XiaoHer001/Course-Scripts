using UnityEngine;

// ================================================
// 实现功能: 冒泡排序简单示例
// 编码作者: 小贺儿
// 修改时间: 2025年02月13日 09:55:18
// 修改内容: 新建脚本
// 备注说明: 该脚本挂载在BubbleSort同名物体对象上
// ================================================

public class BubbleSort : MonoBehaviour
{
    private int[] num = { 5, 2, 1, 4, 3 };

    void Start()
    {
        BubbleSortArray(num);
        // 使用 string.Join() 输出排序后的数组
        Debug.Log($"冒泡排序结果: {string.Join(" , ", num)}");
    }

    void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        // 外层循环控制排序的轮数
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;  // 每一轮开始时，假设没有发生交换

            // 内层循环进行相邻元素的比较和交换
            for (int j = 0; j < n - 1 - i; j++)
            {
                // 如果当前元素比下一个元素大，就交换它们
                if (arr[j] > arr[j + 1])
                {
                    // 交换元素
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;  // 发生了交换
                }
            }

            // 如果一轮比较没有发生交换，说明数组已经有序，提前结束
            if (!swapped)
            {
                break;
            }
        }
    }
}
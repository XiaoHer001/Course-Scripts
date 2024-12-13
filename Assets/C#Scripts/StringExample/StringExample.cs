using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ================================================
// 实现功能: 字符串的常用操作
// 编码作者: 小贺儿
// 修改时间: 2024年11月28日 11:27:56
// 修改内容: 
// 备注说明: 
// ================================================

public class StringExample : MonoBehaviour
{
    void Start()
    {
        // 创建字符串
        string strName = "玩家";
        // 字符串拼接
        //string message = "你好，" + strName + "!";
        // 字符串插值 将变量或表达式直接嵌入到字符串中
        int score = 100;
        string message = $"你好，{strName}! 你的分数为{score}";
        // 获取字符串的长度
        //Debug.Log(message.Length);
        // 判断当前字符串中是否包含某个子字符串
        //Debug.Log(message.Contains("123"));
        // 替换字符串
        //Debug.Log(message.Replace("分数","等级"));
        // 去除开头和结尾的空白字符 空格 制表符 换行符 回车符 或者指定的字符等等
        //Debug.Log(message.Trim('*'));
        // 分割字符串
        // string message = "小王,小李,小张";
        // string[] results = message.Split(',');
        // foreach (string result in results)
        // {
        //     Debug.Log(result);
        // }
        // 合并字符串数组
        // string[] words = { "小王", "小李", "小张" };
        // Debug.Log(string.Join("*", words));
        // 字符串的格式化
        //string result = string.Format("姓名: {0},分数为: {1:F2}", strName, score);
        //string result = string.Format("当前日期为: {0:yyyy-MM-dd}", DateTime.Now);
        // 字符串的比较
        //string StrName = "小五";
        // 获取字符串
        string subMessage = message.Substring(0,2);
        Debug.Log(subMessage);
    }
    void Update()
    {

    }
}
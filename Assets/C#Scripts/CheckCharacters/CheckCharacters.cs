// Copyright (c) 2024 XiaoHer001
//
// This software is licensed under the MIT License. 
// See the LICENSE file for full details.

using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 检查字符串中是否包含特殊字符 \ : ! @ # $ % & ^ * ( ) / | [ ] { }
/// </summary>
public class CheckCharacters : MonoBehaviour
{
    void Start()
    {
        Check();
    }
    /// <summary>
    /// 检查输入字符串中的特殊字符
    /// </summary>
    /// <param name="inputString">需要检查的字符串</param>
    /// <returns>包含在字符串中的特殊字符列表</returns>
    private List<string> CheckForSpecialCharacters(string inputString)
    {
        // 定义需要检查的特殊字符
        string specialCharacters = "\\:!@#$%&^*()/|[]{}";
        // 创建一个列表来存储找到的特殊字符
        List<string> foundCharacters = new List<string>();

        // 遍历输入字符串中的每个字符
        foreach (char character in inputString)
        {
            // 检查当前字符是否在特殊字符列表中
            if (specialCharacters.Contains(character))
            {
                // 如果是，将字符转换为字符串并添加到列表中
                foundCharacters.Add(character.ToString());
            }
        }
        // 返回找到的特殊字符列表
        return foundCharacters;
    }

    /// <summary>
    /// 测试检查特殊字符的方法
    /// </summary>
    private void Check()
    {
        // 定义一个测试字符串
        string testString = "该字符串包含特殊字符 \\ and !";
        // 调用方法检查字符串中的特殊字符
        List<string> specialChars = CheckForSpecialCharacters(testString);

        // 如果找到特殊字符，输出结果
        if (specialChars.Count > 0)
        {
            Debug.Log($"该字符串包含特殊字符: {string.Join("和 ", specialChars)}");
        }
        else
        {
            // 如果未找到特殊字符，输出提示信息
            Debug.Log("该字符串不包含特殊字符");
        }
    }
}
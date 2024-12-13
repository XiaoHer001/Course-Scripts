using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    // 音频音量调节Slider
    public Slider AudioSlider;
    // 背景音频
    public AudioSource BackAudio;
    void Start()
    {
        // 对Slider进行初始化
        AudioSlider.value = BackAudio.volume;
        // 添加监听事件
        AudioSlider.onValueChanged.AddListener(SetVolume);
    }
    private void SetVolume(float volume)
    {
        BackAudio.volume = volume;
    }
}

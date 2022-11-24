﻿
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    /// 套用程式時執行：要求元件(類型(元件)) - 第一次套用腳本給物件時會添加元件
    [RequireComponent(typeof(AudioSource))]
    public class SoundManger : MonoBehaviour
    {
        public static SoundManger instance;

        private AudioSource aud;

        private void Awake()
        {
            //this 此類別
            instance = this;

            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音樂
        /// </summary>
        /// <param name="sound">音效</param>
        /// <param name="rangeVolum"></param>
        public void PlaySound(AudioClip sound,Vector2 rangeVolum)
        {
            float volume = Random.Range(rangeVolum.x, rangeVolum.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}


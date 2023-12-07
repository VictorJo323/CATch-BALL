using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneBGM : MonoBehaviour
{
    public AudioClip lowScoreSound;
    public AudioClip highScoreSound;
    public float volume = 0.5f;

    private void Start()
    {
        if (GameManager.I.PlayerScore>20)
        {
            AudioManager.instance.bgmPlayer.Stop();
            Invoke("PlayHighScore", 1.5f);
        }
        else
        {
            AudioManager.instance.bgmPlayer.Stop();
            Invoke("PlayLowScore", 1.5f);
        }
    }

    void PlayHighScore()
    {
        PlaySoundOnce(highScoreSound);
    }

    void PlayLowScore()
    {
        PlaySoundOnce(lowScoreSound);
    }
    private void PlaySoundOnce(AudioClip clip)
    {
        AudioManager.instance.bgmPlayer.clip = clip;
        AudioManager.instance.bgmPlayer.volume = volume;
        AudioManager.instance.bgmPlayer.loop = false;
        AudioManager.instance.bgmPlayer.Play();
    }
}

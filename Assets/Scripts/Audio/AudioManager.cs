using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [Header("#BGM")]  //배경음악
    public AudioClip bgmClip;
    public float bgmVolume;
    AudioSource bgmPlayer;
    [Header("#SFX")] // 효과음
    public AudioClip[] sfxClips; // 효과음은 배경음악처럼 하나가 아니라 여러가지기 떄문에 배열로 나타내주기
    public float sfxVolume ;
    public int channels;  // 다량의 효과음을 낼 수 있도록 채널 개수 변수 선언
    AudioSource[] sfxPlayers;
    int channelIndex;
    public enum Sfx { ShootSound, Eatsound, HitSound, PaddleSound, WallSound, DropSound,CatSound, Cat2Sound, BreakSound,StoneBreakSound,Wall2Sound, DogSound}
    private void Awake()
    {
        instance = this;
        Init();
    }
    void Init()
    {
        // 배경음 플레이어 초기화
        GameObject bgmobject = new GameObject("BgmPlayer");
        bgmobject.transform.parent = transform;
        bgmPlayer = bgmobject.AddComponent<AudioSource>();
        bgmPlayer.playOnAwake = false;
        bgmPlayer.loop = true;
        bgmPlayer.volume = bgmVolume;
        bgmPlayer.clip = bgmClip;
        // 효과음 플레이어 초기화
        GameObject sfxobject = new GameObject("SfxPlayer");
        sfxobject.transform.parent = transform;
        sfxPlayers = new AudioSource[channels];
        for (int index = 0; index < sfxPlayers.Length; index++)
        {
            sfxPlayers[index] = sfxobject.AddComponent<AudioSource>();
            sfxPlayers[index].playOnAwake = false;
            sfxPlayers[index].volume = sfxVolume;
            
        }
    }
    public void PlayBgm(bool isPlay)
    {
        if (isPlay)
        {
            bgmPlayer.Play();
        }
        else
        {
            bgmPlayer.Stop();
        }
    }
    public void PlaySfx(Sfx sfx)
    {
        for (int index = 0; index < sfxPlayers.Length; index++)
        {
            int loopIndex = (index + channelIndex) % sfxPlayers.Length;
            if (sfxPlayers[loopIndex].isPlaying)
                continue;
            channelIndex = loopIndex;
            sfxPlayers[loopIndex].clip = sfxClips[(int)sfx];
            sfxPlayers[loopIndex].Play();
            break;
        }
    }
}

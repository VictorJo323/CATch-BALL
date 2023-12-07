using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBGM : MonoBehaviour
{
    public AudioClip audioForScene;
    public float bgmVol = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.SetBGM(audioForScene, bgmVol);
    }

}

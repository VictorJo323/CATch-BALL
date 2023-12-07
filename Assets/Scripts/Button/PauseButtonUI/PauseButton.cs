using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject gameObject;
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);
            AudioManager.instance.PauseBGM();
        }
        
        else
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
            AudioManager.instance.UnpauseBGM();
        }
    }
}

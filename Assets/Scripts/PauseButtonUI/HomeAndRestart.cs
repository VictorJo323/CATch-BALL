using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeAndRestart : MonoBehaviour
{
    public void BackHome()
    {
        BallControl.isBallReleased = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }
    public void RestartNormalGame()
    {
        BallControl.isBallReleased = false;
        Time.timeScale = 1; 
        SceneManager.LoadScene("MainScene_BW");
    }

    public void RestartEndlessGame()
    {
        BallControl.isBallReleased = false;
        Time.timeScale = 1; 
        SceneManager.LoadScene("MainScene_Endless");
    }
}

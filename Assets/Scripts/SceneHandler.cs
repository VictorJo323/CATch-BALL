using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    GameObject[] bricks;
    public bool isGameStart = false;
    private void Update()
    {
        bricks = GameObject.FindGameObjectsWithTag("Brick");
        isGameStart = true;
        if (GameManager.I.PlayerHP <= 0)
        {
            LoadEndScene();
            GameManager.I.PlayerHP += 3;
        }
        if(bricks.Length == 1 && isGameStart == true)
        {
            isGameStart = false;
            LoadEndScene();
        }
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}

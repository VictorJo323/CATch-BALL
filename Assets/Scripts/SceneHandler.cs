using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    private void Update()
    {
        if(GameManager.I.PlayerHP <= 0)
        {
            LoadEndScene();
            GameManager.I.PlayerHP += 3;
        }
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene_BW");
    }
}

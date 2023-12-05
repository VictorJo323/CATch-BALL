using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    void Update()
    {
        Debug.Log("aaaaa");
        if(GameManager.I.PlayerHP <= 0)
        {
            LoadEndScene();
        }
    }

    void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}

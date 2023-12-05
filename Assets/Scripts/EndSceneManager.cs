using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public Text NowScore;

    public void Start()
    {
        NowScore.text = GameManager.I.PlayerScore.ToString();
    }
}

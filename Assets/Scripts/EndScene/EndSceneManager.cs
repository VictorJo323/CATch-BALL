using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class EndSceneManager : MonoBehaviour
{
    public Text nowScoreTxt;
    public Text bestScoreTxt;
    public int nowScore;
    public int bestScore;
    public GameObject bestMark;

    public void Start()
    {
        nowScore = GameManager.I.PlayerScore;
        ShowScore();
    }

    public void ShowScore()
    {
        nowScoreTxt.text = nowScore.ToString();
        LoadBestScore();
        BestScoreUpdate();
        bestScoreTxt.text = bestScore.ToString();
    }

    public void BestScoreUpdate()
    {
        if (bestScore < nowScore)
        {
            bestScore = nowScore;
            bestMark.SetActive(true);
            SaveBestScore();
        }
        else
        {
            SaveBestScore();
        }
    }

    private void SaveBestScore()
    {
        PlayerPrefs.SetInt("HighScore", bestScore);
        PlayerPrefs.Save();
    }

    private void LoadBestScore()
    {
        bestScore = PlayerPrefs.GetInt("HighScore", nowScore);
    }
}

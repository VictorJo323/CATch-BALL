using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneScoreAndonLifeManager : MonoBehaviour
{
    public GameObject onLife3;
    public GameObject onLife2;
    public GameObject onLife1;
    public GameObject offLife3;
    public GameObject offLife2;
    public GameObject offLife1;
    public GameObject bestMark;
    public GameObject nowMark;
    public Text thisScoreTxt;
    public Text bestScoreTxt;

    int nowLife;
    int nowScore;
    int bestScore;

    private void Update()
    {
        nowLife = GameManager.I.PlayerHP;
        nowScore = GameManager.I.PlayerScore;
        LoadBestScore();
        BestScoreUpdate();
        ActiveonLifeObj();
        ScoreUpdate();
        bestScoreTxt.text = bestScore.ToString();
    }

    public void BestScoreUpdate()
    {
        if (bestScore < nowScore)
        {
            bestScore = nowScore;
            bestMark.SetActive(true);
            nowMark.SetActive(false);
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

    private void ScoreUpdate()
    {
        thisScoreTxt.text = nowScore.ToString();
    }

    private void ActiveonLifeObj()
    {
        if (nowLife == 2)
        {
            onLife3.SetActive(false);
            offLife3.SetActive(true);
        }
        if (nowLife == 1)
        {
            onLife2.SetActive(false);
            offLife2.SetActive(true);
        }
        if (nowLife == 0)
        {
            onLife1.SetActive(false);
            offLife1.SetActive(true);
        }
    }
}

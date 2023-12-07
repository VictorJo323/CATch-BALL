using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricksEndless : MonoBehaviour
{
    public GameObject brick1;
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick4;
    public Text levelTxt;
    private GiveIDToBricksEndless giveIDToBricksEndless;

    public float time = 0.0f;
    private float timeToScore = 4;
    private int levelUp = 1;

    void Start()
    {
        giveIDToBricksEndless = new GiveIDToBricksEndless();
        GenerateBrickGroup();
    }

    void Update()
    {
        time += Time.deltaTime;
        levelTxt.text = levelUp.ToString();
        if (time > timeToScore)
        {
            LevelUpValue();
            BlockMove();
            GenerateBrickGroup();
            time = 0;
        }
    }

    void BlockMove()
    {
        GameObject.Find("Bricks").transform.Translate(new Vector3(0, -0.3f, 0));
    }

    void LevelUpValue()
    {
        if (GameManager.I.PlayerScore > levelUp * 100 && GameManager.I.PlayerScore < levelUp * 100 + 100 && timeToScore > 0)
        {
            timeToScore -= 0.5f;
            levelUp++;
        }
    }

    private void GenerateBrickGroup()
    {
        for (int i= 0; i<10; i++)
        {
            GameObject newBrick;
            giveIDToBricksEndless.RandomIDToBricks();
            int id = giveIDToBricksEndless.GiveBrickID(i);
            switch (id)
            {
                case 1:
                    newBrick = Instantiate(brick1);
                    break;
                case 2:
                    newBrick = Instantiate(brick2);
                    break;
                case 3:
                    newBrick = Instantiate(brick3);
                    break;
                default:
                    newBrick = Instantiate(brick4);
                    break;
            }
            newBrick.GetComponent<Brick>().SetBrickID(id);
            newBrick.transform.parent = GameObject.Find("Bricks").transform;

            float x = (i % 10) * 0.54f - 2.44f;
            float y = (i / 10) * 0.28f + 4.8f;
            newBrick.transform.position = new Vector2(x, y-2);
        }
    }
}
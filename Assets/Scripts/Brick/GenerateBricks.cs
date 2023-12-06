using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour
{
    public GameObject brick1;
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick4;
    private GiveIDToBricks giveIDToBricks;

    public float time = 0.0f;
    private int blockNum;
    void Start()
    {
        giveIDToBricks = new GiveIDToBricks();
        GenerateBrickGroup();
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > 3&&blockNum <= 9)
        {
           BlockMove();
           if (blockNum>1)
            {
                GenerateBrick();
            }
            
            time = 0;
        }
    }

    void BlockMove()
    {
        GameObject.Find("Bricks").transform.Translate(new Vector3(0, -0.6f, 0));
        blockNum += 1;
    }

    private void GenerateBrickGroup()
    {
        for (int i= 0; i<70; i++)
        {
            GameObject newBrick;
            int id = giveIDToBricks.GiveBrickID(i);
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
            float y = (i / 10) * 0.28f;
            newBrick.transform.position = new Vector2(x, y);
        }
    }

    private void GenerateBrick()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject newBrick;
            int id = giveIDToBricks.GiveBrickID(i);
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
            float y = (i / 10) * 0.28f;
            newBrick.transform.position = new Vector2(x, y);
        }
    }
}

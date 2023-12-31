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
    void Start()
    {
        giveIDToBricks = new GiveIDToBricks();
        GenerateBrickGroup();
    }

    private void GenerateBrickGroup()
    {
        for (int i= 0; i<63; i++)
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

            float x = (i % 9) * 0.54f - 2.16f;
            float y = (i / 9) * 0.28f;
            newBrick.transform.position = new Vector2(x, y);
        }
    }
}

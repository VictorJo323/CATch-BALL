using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveIDToBricks
{
    public int[] brickID;
    private System.Random random;

    public GiveIDToBricks()
    {
        random = new System.Random();
        brickID = new int[70];

        for (int i = 0; i < 70; i++)
        {
            brickID[i] = random.Next(1, 5);
        }
    }

    public int GiveBrickID(int index)
    {
        return brickID[index];
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveIDToBricksEndless
{
    public int[] brickID;
    private System.Random random;

    public void RandomIDToBricks()
    {
        random = new System.Random();
        brickID = new int[10];

        for (int i = 0; i < 10; i++)
        {
            brickID[i] = random.Next(1, 5);
        }
    }

    public int GiveBrickID(int index)
    {
        return brickID[index];
    }    
}

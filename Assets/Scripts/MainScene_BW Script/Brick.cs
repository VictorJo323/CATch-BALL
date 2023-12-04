using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Brick : MonoBehaviour
{
    public int brickID;
    ItemManager itemManager;

    public void SetBrickID(int id)
    {
        brickID = id;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        itemManager.DropItem(brickID, gameObject.transform.position);
    }


}

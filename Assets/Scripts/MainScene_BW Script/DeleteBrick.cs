using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBrick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            int brickID = GetComponent<Brick>().brickID;
            ItemManager.Instance.DropItem(brickID, transform.position);
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour
{
    public static ItemCreator Instance { get; private set; }
    public GameObject[] items;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void DropItem(int itemID, Vector2 position)
    {
        if (itemID<=0 || itemID -1 >= items.Length)
        {
            Debug.LogWarning("NoItem");
            return;
        }
        Instantiate(items[itemID - 1], position, Quaternion.identity);
    }
}



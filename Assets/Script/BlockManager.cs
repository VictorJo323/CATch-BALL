using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class BlockManager : MonoBehaviour
{

    public int getItem;

    // Start is called before the first frame update
    void Start()
    {
        blockItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void blockItem()
    {
        int[] items = { 1, 2, 3, 4, 5 };
        int itemCollect = Random.Range(0, 4);

        getItem = items[itemCollect];

    }

}

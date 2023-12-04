using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using static Unity.Collections.AllocatorManager;
using static UnityEditor.Progress;

public class BlockManager : MonoBehaviour
{
    public int Item;

    public GameObject ItemO1;
    public GameObject ItemO2;
    public GameObject ItemO3;
    public GameObject ItemO4;

    

    // Start is called before the first frame update
    void Start()
    {
        BlockItem();
        string itemName = "item0" + Item;
        transform.Find("Item").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(itemName);
    }

    // Update is called once per frame
    void OnDestroy()
    {

        GameObject newItem;
        switch (Item)
        {
            case 1:
                newItem = Instantiate(ItemO1);
                newItem.transform.position = gameObject.transform.Find("Item").position;
                break;

            case 2:
                newItem = Instantiate(ItemO2);
                newItem.transform.position = gameObject.transform.Find("Item").position;
                break;

            case 3:
                newItem = Instantiate(ItemO3);
                newItem.transform.position = gameObject.transform.Find("Item").position;
                break;

            default:
                newItem = Instantiate(ItemO4);
                newItem.transform.position = gameObject.transform.Find("Item").position;
                break;

        }
        newItem.transform.parent = GameObject.Find("Items").transform;


    }
    private void OnDisenable()
    {
        Destroy(gameObject);
    }

    void BlockItem()
    {
        int[] items = { 1, 2, 3, 4 };
        int itemCollect = Random.Range(0, 3);

        Item = items[itemCollect];

    }


    

}

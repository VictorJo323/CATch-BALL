using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public GameObject block;
    public float time = 0.0f;
    private int blockNum;


    void Awake()
    {
        time = 0;
        blockNum = 1;
    
    }

    // Start is called before the first frame update

    void Start()
    {
        BlockCreate();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1 && blockNum < 9)
        {
            BlockMove();
            BlockCreate();
            time = 0;

        }
    }

    public void BlockCreate()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject newBlock = Instantiate(block);
            newBlock.transform.parent = GameObject.Find("Blocks").transform;
            float x = (i % 4) * 1f -1f ;
            float y = (i / 4) * 1f +4f ;
            newBlock.transform.position = new Vector3(x, y, 0);
        }

    }

    void BlockMove()
    {
        GameObject.Find("Blocks").transform.Translate(new Vector3(0,-1,0));
        blockNum += 1;

    }


}

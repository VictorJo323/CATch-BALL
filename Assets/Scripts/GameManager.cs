using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public int PlayerHP;
    public Text timeTxt;
    public GameObject EndTxt;

    private void Awake()
    {
        I = this;
        PlayerHP = 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP==0)
        {
            GameEnd();
        }
    }

    void GameEnd()
    {
        EndTxt.SetActive(true);
    }


}

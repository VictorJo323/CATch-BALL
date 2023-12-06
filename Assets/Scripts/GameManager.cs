using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using static UnityEditor.Progress;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public int PlayerHP;
    public GameObject EndTxt;
    public int PlayerScore;

    private void Awake()
    {
        I = this;
        PlayerHP = 3;
        PlayerScore = 0;
    }



    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (PlayerHP==0)
    //    {
    //        GameEnd();
    //    }
    //    Debug.Log(PlayerScore);
    //}

    //void GameEnd()
    //{
    //    EndTxt.SetActive(true);
    //}

   

}

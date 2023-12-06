using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SelectCAT : MonoBehaviour
{
    public GameObject PaddleCAT;
    public GameObject PaddleDOG;

    public void Start()
    {
        PaddleCAT.SetActive(DataHolder.Instance.button1);
        PaddleDOG.SetActive(DataHolder.Instance.button2);
    }
    
}

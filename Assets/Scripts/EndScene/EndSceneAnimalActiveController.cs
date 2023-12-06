using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneAnimalActiveController : MonoBehaviour
{
    public GameObject normalCat;
    public GameObject cryingCat;

    void Start()
    {
        if (GameManager.I.PlayerScore >= 20)
        {
            normalCat.SetActive(true);
        }
        else
        {
            cryingCat.SetActive(true);
        }
    }
}

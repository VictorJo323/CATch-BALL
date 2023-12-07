using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneAnimalActiveController : MonoBehaviour
{
    public GameObject normalCat;
    public GameObject cryingCat;
    public GameObject normalDog;
    public GameObject cryingDog;
    private DataHolder dataHolder;

    void Start()
    {
        if (DataHolder.Instance.button1)
        {
            if (GameManager.I.PlayerScore >= 30)
            {
                normalCat.SetActive(true);
            }
            else
            {
                cryingCat.SetActive(true);
            }
        }
        else if (DataHolder.Instance.button2)
        {
            if (GameManager.I.PlayerScore >= 30)
            {
                normalDog.SetActive(true);
            }
            else
            {
                cryingDog.SetActive(true);
            }
        }
    }
}

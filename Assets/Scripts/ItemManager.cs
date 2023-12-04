using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.TextCore.Text;
using UnityEditorInternal.Profiling.Memory.Experimental;
using Unity.VisualScripting;

public class ItemManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            switch (gameObject.name)
            {
                case "Item_01(Clone)":
                    iteme1();
                    break;

                case "Item_02(Clone)":
                    iteme2();
                    break;

                case "Item_03(Clone)":
                    iteme3();
                    break;

                default:
                    iteme4();
                    break;
            }
            Destroy(gameObject);
        }
    }

    static public void iteme1()
    {
        GameManager.I.PlayerScore += 1;
    }
    static public void iteme2()
    {
        GameManager.I.PlayerScore += 2;
    }

    static public void iteme3()
    {
        GameManager.I.PlayerScore += 3;
    }

    static public void iteme4()
    {
        GameManager.I.PlayerScore += 4;
    }

    private void OnDisenable()
    {
        Destroy(gameObject);
    }


}

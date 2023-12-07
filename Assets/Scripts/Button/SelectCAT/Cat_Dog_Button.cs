using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatButton : MonoBehaviour
{

   
    public void Button1OnOff()
    {
        DataHolder.Instance.Button1();
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Cat2Sound);
    }
    public void Button2OnOff()
    {
        DataHolder.Instance.Button2();
        AudioManager.instance.PlaySfx(AudioManager.Sfx.DogSound);
    }
}

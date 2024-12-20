using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI8 : MonoBehaviour
{
    public GameObject arabasınnıs8;
    public arabasecd kod8;
    public int yazımsın8;

    void Update()
    {
        yazımsın8 = PlayerPrefs.GetInt("selamcık8");
        
        if (yazımsın8 == 2)
        {
            arabasınnıs8.SetActive(true);
        }

        if (yazımsın8 == 0)
        {
            arabasınnıs8.SetActive(false);
        }

    }

}

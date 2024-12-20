using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI7 : MonoBehaviour
{
    public GameObject arabasınnıs7;
    public arabasecd kod7;
    public int yazımsın7;

    void Update()
    {
        yazımsın7 = PlayerPrefs.GetInt("selamcık7");

        if (yazımsın7 == 2)
        {
            arabasınnıs7.SetActive(true);
        }

        if (yazımsın7 == 0)
        {
            arabasınnıs7.SetActive(false);
        }

    }

}

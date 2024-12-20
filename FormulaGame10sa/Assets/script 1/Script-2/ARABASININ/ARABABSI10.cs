using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI10 : MonoBehaviour
{
    public GameObject arabasınnıs10;
    public arabasecd kod10;
    public int yazımsın10;

    void Update()
    {
        yazımsın10 = PlayerPrefs.GetInt("selamcık10");

        if (yazımsın10 == 2)
        {
            arabasınnıs10.SetActive(true);
        }

        if (yazımsın10 == 0)
        {
            arabasınnıs10.SetActive(false);
        }

    }

}

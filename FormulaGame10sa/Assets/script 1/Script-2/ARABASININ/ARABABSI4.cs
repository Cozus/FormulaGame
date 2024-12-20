using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI4 : MonoBehaviour
{
    public GameObject arabasınnıs4;
    public arabasecd kod4;
    public int yazımsın4;

    void Update()
    {
        yazımsın4 = PlayerPrefs.GetInt("selamcık4");

        if (yazımsın4 == 2)
        {
            arabasınnıs4.SetActive(true);
        }

        if (yazımsın4 == 0)
        {
            arabasınnıs4.SetActive(false);
        }

    }

}

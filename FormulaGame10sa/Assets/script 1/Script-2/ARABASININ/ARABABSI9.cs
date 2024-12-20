using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI9 : MonoBehaviour
{
    public GameObject arabasınnıs9;
    public arabasecd kod9;
    public int yazımsın9;

    void Update()
    {
        yazımsın9= PlayerPrefs.GetInt("selamcık9");

        if (yazımsın9 == 2)
        {
            arabasınnıs9.SetActive(true);
        }

        if (yazımsın9 == 0)
        {
            arabasınnıs9.SetActive(false);
        }

    }

}

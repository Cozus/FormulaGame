using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI5 : MonoBehaviour
{
    public GameObject arabasınnıs5;
    public arabasecd kod5;
    public int yazımsın5;

    void Update()
    {
        yazımsın5 = PlayerPrefs.GetInt("selamcık5");

        if (yazımsın5 == 2)
        {
            arabasınnıs5.SetActive(true);
        }

        if (yazımsın5 == 0)
        {
            arabasınnıs5.SetActive(false);
        }

    }

}

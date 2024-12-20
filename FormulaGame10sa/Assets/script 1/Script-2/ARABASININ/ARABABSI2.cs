using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI2 : MonoBehaviour
{
    public GameObject arabasınnıs2;
    public arabasecd kod2;
    public int yazımsın2;

    void Update()
    {
        yazımsın2 = PlayerPrefs.GetInt("selamcık2");

        if (yazımsın2 == 2)
        {
            arabasınnıs2.SetActive(true);
        }

        if (yazımsın2 == 0)
        {
            arabasınnıs2.SetActive(false);
        }

    }

}

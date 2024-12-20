using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI6 : MonoBehaviour
{
    public GameObject arabasınnıs6;
    public arabasecd kod6;
    public int yazımsın6;

    void Update()
    {
        yazımsın6 = PlayerPrefs.GetInt("selamcık6");

        if (yazımsın6 == 2)
        {
            arabasınnıs6.SetActive(true);
        }

        if (yazımsın6 == 0)
        {
            arabasınnıs6.SetActive(false);
        }

    }

}

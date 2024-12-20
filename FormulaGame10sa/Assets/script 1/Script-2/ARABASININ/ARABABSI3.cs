using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI3 : MonoBehaviour
{
    public GameObject arabasınnıs3;
    public arabasecd kod3;
    public int yazımsın3;

    void Update()
    {
        yazımsın3 = PlayerPrefs.GetInt("selamcık3");

        if (yazımsın3 == 2)
        {
            arabasınnıs3.SetActive(true);
        }

        if (yazımsın3 == 0)
        {
            arabasınnıs3.SetActive(false);
        }

    }

}

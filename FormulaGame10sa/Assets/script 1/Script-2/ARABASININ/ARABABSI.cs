using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARABABSI : MonoBehaviour
{
    public GameObject arabasınnıs1;
    public arabasecd kod1;
    public int yazımsın;
    
    void Update()
    {
        yazımsın = PlayerPrefs.GetInt("selamcık");

        if(yazımsın==2)
        {
            arabasınnıs1.SetActive(true);
        }

        if (yazımsın == 0)
        {
            arabasınnıs1.SetActive(false);
        }

    }

  
}

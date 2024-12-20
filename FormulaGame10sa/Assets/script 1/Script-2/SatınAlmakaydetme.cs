using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatınAlmakaydetme : MonoBehaviour
{
    public int formula1;
    public int formula2;
    public int formula3;
    public int formula4;
    public int formula5;
    public int formula6;
    public int formula7;
    public int formula8;
    public int formula9;
    public int formula10;
    public int formula11;
    public int formula12;


    public int formula1fiyat;
    public int formula2fiyat;
    public int formula3fiyat;
    public int formula4fiyat;
    public int formula5fiyat;
    public int formula6fiyat;
    public int formula7fiyat;
    public int formula8fiyat;
    public int formula9fiyat;
    public int formula10fiyat;
    public int formula11fiyat;
    public int formula12fiyat;


    public GameObject formula1kilid;
    public GameObject formula2kilid;
    public GameObject formula3kilid;
    public GameObject formula4kilid;
    public GameObject formula5kilid;
    public GameObject formula6kilid;
    public GameObject formula7kilid;
    public GameObject formula8kilid;
    public GameObject formula9kilid;
    public GameObject formula10kilid;
    public GameObject formula11kilid;
    public GameObject formula12kilid;

    public GameObject formula1satınal;
    public GameObject formula2satınal;
    public GameObject formula3satınal;
    public GameObject formula4satınal;
    public GameObject formula5satınal;
    public GameObject formula6satınal;
    public GameObject formula7satınal;
    public GameObject formula8satınal;
    public GameObject formula9satınal;
    public GameObject formula10satınal;
    public GameObject formula11satınal;
    public GameObject formula12satınal;

    public GameObject testseyi;

    

    



    void Start()
    {
        formula1 = PlayerPrefs.GetInt("formula1");
        formula2 = PlayerPrefs.GetInt("formula2");
        formula3 = PlayerPrefs.GetInt("formula3");
        formula4 = PlayerPrefs.GetInt("formula4");
        formula5 = PlayerPrefs.GetInt("formula5");
        formula6 = PlayerPrefs.GetInt("formula6");
        formula7 = PlayerPrefs.GetInt("formula7");
        formula8 = PlayerPrefs.GetInt("formula8");
        formula9 = PlayerPrefs.GetInt("formula9");
        formula10 = PlayerPrefs.GetInt("formula10");
        formula11 = PlayerPrefs.GetInt("formula11");
        formula12 = PlayerPrefs.GetInt("formula12");
        formula6 = 7;
        
        

    }


    void Update()
    {
        PlayerPrefs.SetInt("formula1", formula1);
        PlayerPrefs.SetInt("formula2", formula2);
        PlayerPrefs.SetInt("formula3", formula3);
        PlayerPrefs.SetInt("formula4", formula4);
        PlayerPrefs.SetInt("formula5", formula5);
        PlayerPrefs.SetInt("formula6", formula6);
        PlayerPrefs.SetInt("formula7", formula7);
        PlayerPrefs.SetInt("formula8", formula8);
        PlayerPrefs.SetInt("formula9", formula9);
        PlayerPrefs.SetInt("formula10", formula10);
        PlayerPrefs.SetInt("formula11", formula11);
        PlayerPrefs.SetInt("formula12", formula12);

        formula6 = 7;
        


        if (formula1 == 2)
        {
            formula1kilid.SetActive(false);
            formula1satınal.SetActive(true);
        }

        if (formula2 == 3)
        {
            formula2kilid.SetActive(false);
            formula2satınal.SetActive(true);
        }

        if (formula3 == 4)
        {
            formula3kilid.SetActive(false);
            formula3satınal.SetActive(true);
        }

        if (formula4 == 5)
        {
            formula4kilid.SetActive(false);
            formula4satınal.SetActive(true);

        }

        if (formula5 == 6)
        {
            formula5kilid.SetActive(false);
            formula5satınal.SetActive(true);
        }

        if (formula6 == 7)
        {
            formula6kilid.SetActive(false);
            formula6satınal.SetActive(true);
        }

        if (formula7 == 8)
        {
            formula7kilid.SetActive(false);
            formula7satınal.SetActive(true);
        }

        if (formula8 == 9)
        {

            formula8satınal.SetActive(true);

        }

        if (formula9 == 10)
        {
            formula9kilid.SetActive(false);
            formula9satınal.SetActive(true);
        }

        if (formula10 == 11)
        {
            formula10kilid.SetActive(false);
            formula10satınal.SetActive(true);
        }

        if (formula11 == 12)
        {
            formula11kilid.SetActive(false);
            formula11satınal.SetActive(true);
        }

        if (formula12 == 13)
        {
            formula12kilid.SetActive(false);
            formula12satınal.SetActive(true);
        }

    }

 }

    
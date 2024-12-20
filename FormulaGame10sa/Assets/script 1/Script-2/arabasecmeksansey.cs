using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formulayısecsicisi : MonoBehaviour
{

    public int secmesayısı;
    public int secmesayısı2;
    public int secmesayısı3;
    public int secmesayısı4;
    public int secmesayısı5;
    public int secmesayısı6;
    public int secmesayısı7;
    public int secmesayısı8;
    public int secmesayısı9;
    public int secmesayısı10;

    public GameObject beyazkırmızıdetaylı;
    public GameObject kırmızısiyahlı;
    public GameObject mavisiyahlı;
    public GameObject siyahful;
    public GameObject beyazmorsarı;
    public GameObject mavimorsarı;
    public GameObject beyazmor;
    public GameObject sarısiyah;
    public GameObject beyazsiyah;
    public GameObject beyazsiyah2;

    public bool Araba1;
    public bool araba2;
    public bool araba3;
    public bool araba4;
    public bool araba5;
    public bool araba6;
    public bool araba7;
    public bool araba8;
    public bool araba9;
    public bool araba10;


    void Start()
    {


        secmesayısı = PlayerPrefs.GetInt("secmesayısı");
        secmesayısı2 = PlayerPrefs.GetInt("secmesayısı2");
        secmesayısı3 = PlayerPrefs.GetInt("secmesayısı3");
        secmesayısı4 = PlayerPrefs.GetInt("secmesayısı4");
        secmesayısı5 = PlayerPrefs.GetInt("secmesayısı5");
        secmesayısı6 = PlayerPrefs.GetInt("secmesayısı6");
        secmesayısı7 = PlayerPrefs.GetInt("secmesayısı7");
        secmesayısı8 = PlayerPrefs.GetInt("secmesayısı8");
        secmesayısı9 = PlayerPrefs.GetInt("secmesayısı9");
        secmesayısı10 = PlayerPrefs.GetInt("secmesayısı10");

    }


    void Update()
    {



        PlayerPrefs.SetInt("secmesayısı", secmesayısı);
        PlayerPrefs.SetInt("secmesayısı2", secmesayısı2);
        PlayerPrefs.SetInt("secmesayısı3", secmesayısı3);
        PlayerPrefs.SetInt("secmesayısı4", secmesayısı4);
        PlayerPrefs.SetInt("secmesayısı5", secmesayısı5);
        PlayerPrefs.SetInt("secmesayısı6", secmesayısı6);
        PlayerPrefs.SetInt("secmesayısı7", secmesayısı7);
        PlayerPrefs.SetInt("secmesayısı8", secmesayısı8);
        PlayerPrefs.SetInt("secmesayısı9", secmesayısı9);
        PlayerPrefs.SetInt("secmesayısı10", secmesayısı10);


        if (secmesayısı == 2)
        {

            Araba1 = true;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = false;





        }

        if (secmesayısı == 3)
        {
            Araba1 = false;
            araba2 = true;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 4)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = true;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 5)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = true;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 6)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = true;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 7)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = true;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 8)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = true;
            araba8 = false;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 9)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = true;
            araba9 = false;
            araba10 = false;
        }

        if (secmesayısı == 10)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = true;
            araba10 = false;
        }

        if (secmesayısı == 11)
        {
            Araba1 = false;
            araba2 = false;
            araba3 = false;
            araba4 = false;
            araba5 = false;
            araba6 = false;
            araba7 = false;
            araba8 = false;
            araba9 = false;
            araba10 = true;
        }

    }

    public void Beyazkırmızılısıx()
    {
        secmesayısı = 2;
    }

    public void Beyazmorx()
    {
        secmesayısı = 3;
    }

    public void Beyazmorsarıx()
    {
        secmesayısı = 4;
    }

    public void Beyazsiyahx()
    {
        secmesayısı = 5;
    }

    public void Beyazsiyah2x()
    {
        secmesayısı = 6;
    }

    public void Kırmızısiyahx()
    {
        secmesayısı = 7;
    }

    public void Mavimorsarıx()
    {
        secmesayısı = 8;
    }

    public void Mavisiyahx()
    {
        secmesayısı = 9;
    }

    public void Sarısiyahx()
    {
        secmesayısı = 10;
    }

    public void Siyahfulx()
    {
        secmesayısı = 11;
    }


}

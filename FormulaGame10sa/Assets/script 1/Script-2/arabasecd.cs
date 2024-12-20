using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arabasecd : MonoBehaviour
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

    
    public int Araba1;
    public int araba2;
    public int araba3;
    public int araba4;
    public int araba5;
    public int araba6;
    public int araba7;
    public int araba8;
    public int araba9;
    public int araba10;
    


    void Start()
    {

        secmesayısı = 11;
        Araba1 = 2;
        secmesayısı = PlayerPrefs.GetInt("secmesayısı");
        

    }


    void Update()
    {
        



        PlayerPrefs.SetInt("secmesayısı", secmesayısı);
        


        if (secmesayısı == 2)
        {

            Araba1 = 0;
            araba2 = 2;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;





        }

        if (secmesayısı == 3)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 2;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;
        }

        if (secmesayısı == 4)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 2;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;
        }

        if (secmesayısı == 5)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 2;
        }

        if (secmesayısı== 6)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 2;
            araba10 = 0;
        }

        if (secmesayısı == 7)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 2;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;
        }

        if (secmesayısı == 8)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 2;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;
        }

        if (secmesayısı == 9)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 2;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;
        }

        if (secmesayısı == 10)
        {
            Araba1 = 0;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 2;
            araba9 = 0;
            araba10 = 0;
        }

        if (secmesayısı == 11)
        {
            Araba1 = 2;
            araba2 = 0;
            araba3 = 0;
            araba4 = 0;
            araba5 = 0;
            araba6 = 0;
            araba7 = 0;
            araba8 = 0;
            araba9 = 0;
            araba10 = 0;
        }

        PlayerPrefs.SetInt("selamcık", Araba1);
        PlayerPrefs.SetInt("selamcık2", araba2);
        PlayerPrefs.SetInt("selamcık3", araba3);
        PlayerPrefs.SetInt("selamcık4", araba4);
        PlayerPrefs.SetInt("selamcık5", araba5);
        PlayerPrefs.SetInt("selamcık6", araba6);
        PlayerPrefs.SetInt("selamcık7", araba7);
        PlayerPrefs.SetInt("selamcık8", araba8);
        PlayerPrefs.SetInt("selamcık9", araba9);
        PlayerPrefs.SetInt("selamcık10", araba10);


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
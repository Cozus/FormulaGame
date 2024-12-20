using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hızısınırı : MonoBehaviour
{
    public float yolhızı;

    public int Score = 1;
    public Text ScoreText;
    public float artır = -0.4f;
    public GameObject[] Seritler;
    public GameObject renkserit;
    public GameObject[] OzelSpawn;

    public GameObject kazanma;

    public GameObject Kırmızısiyah;
    public GameObject beyazsiyah;
    public GameObject mavimorsarı;
    public GameObject morsarı;
    public GameObject beyazkırmızı;
    public GameObject beyazmavi;
    public GameObject siyahsarı;
    public GameObject turuncumorbeyaz;
    public GameObject beyazsiyahv2;

    public int acılka1;
    public int acılka2;
    public int acılka3;
    public int acılka4;
    public int acılka5;
    public int acılka6;
    public int acılka7;
    public int acılka8;
    public int acılka9;


   




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


    


    public GameObject durdur;
    public GameObject durdurtus;
    public int uzaksan = 6;
    public int sa = 3;
    public int asg = 2;


    public GameObject sol1;
    public GameObject sol2;
    public GameObject sol3;
    public GameObject sol4;

    public GameObject sag1;
    public GameObject sag2;
    public GameObject sag3;
    public GameObject sag4;

    public GameObject orta1;
    public GameObject orta2;
    public GameObject orta3;
    public GameObject orta4;

    public float bekleme1;
    public float bekleme2;
    public float bekleme3;
    public float bekleme4;
    public float bekleme5;
    public float bekleme6;
    public float bekleme7;
    public float bekleme8;
    public float bekleme9;
    public float bekleme10;
    public float bekleme11;
    public float bekleme12;
    public GameObject testkn;

    public float özeltuzakgelmesayısı = 500;

    public float süre = 8;

    public int slowlesayı;
    public GameObject slowgeldi;

    
    public GameObject slowtus;

    

    public int carscorekac;
    public int carscorekac1;
    public int carscorekac2;
    public int carscorekac3;
    public int carscorekac4;
    public int carscorekac5;
    public int carscorekac6;
    public int carscorekac7;
    public int carscorekac8;

    public int esitlikicin;
    public int esitlikicin1;
    public int esitlikicin2;
    public int esitlikicin3;
    public int esitlikicin4;
    public int esitlikicin5;
    public int esitlikicin6;
    public int esitlikicin7;
    public int esitlikicin8;

    public int suluk;

    public int kapantı;

    public Text highscore;

    public GameObject tutorialmenu;
    public void durdurbas()
    {
        uzaksan = sa;
        durdur.SetActive(true);
        durdurtus.SetActive(false);
        Time.timeScale = 0;

        PlayerPrefs.SetInt("uzaksa", uzaksan);
    }

    public void tutorialdevam()
    {
        suluk += 1;
        uzaksan = asg;
        kapantı += 1;
        Time.timeScale = 1;
        PlayerPrefs.SetInt("suluk", suluk);
        PlayerPrefs.SetInt("uzaksa", uzaksan);
        PlayerPrefs.SetInt("kapantının", kapantı);
    }

    public void devamet()
    {
        durdur.SetActive(false);
        durdurtus.SetActive(true);
        Time.timeScale = 1;
        uzaksan = asg;
        PlayerPrefs.SetInt("uzaksa", uzaksan);
    }
    public void devametmenu()
    {
        
        Time.timeScale = 1;
        uzaksan = asg;
        PlayerPrefs.SetInt("uzaksa", uzaksan);
    }

    public void highscoresil()
    {
        PlayerPrefs.DeleteKey("highscore");
    }

  





    void Start()
    {
        yolhızı=PlayerPrefs.GetFloat("hızcek");

        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        

        carscorekac = 2000;
        carscorekac1 = 4000;
        carscorekac2 = 5200;
        carscorekac3 =6000;
        carscorekac4 = 6700;
        carscorekac5 = 7200;
        carscorekac6 = 8000;
        carscorekac7 = 9000;
        carscorekac8 = 12000;

        esitlikicin = 1999;
        esitlikicin1 = 3199;
        esitlikicin2 = 3999;
        esitlikicin3 = 4999;
        esitlikicin4 = 5999;
        esitlikicin5 = 6999;
        esitlikicin6 = 7499;
        esitlikicin7 = 8499;
        esitlikicin8 = 10999;

        kapantı = PlayerPrefs.GetInt("kapantının");
        suluk = PlayerPrefs.GetInt("suluk");
        acılka1 = PlayerPrefs.GetInt("acılka1");
        acılka2 = PlayerPrefs.GetInt("acılka2");
        acılka3 = PlayerPrefs.GetInt("acılka3");
        acılka4 = PlayerPrefs.GetInt("acılka4");
        acılka5 = PlayerPrefs.GetInt("acılka5");
        acılka6 = PlayerPrefs.GetInt("acılka6");
        acılka7 = PlayerPrefs.GetInt("acılka7");
        acılka8 = PlayerPrefs.GetInt("acılka8");
        acılka9 = PlayerPrefs.GetInt("acılka9");

        carscorekac = PlayerPrefs.GetInt("carscore");
        carscorekac1 = PlayerPrefs.GetInt("carscore1");
        carscorekac2 = PlayerPrefs.GetInt("carscore2");
        carscorekac3 = PlayerPrefs.GetInt("carscore3");
        carscorekac4 = PlayerPrefs.GetInt("carscore4");
        carscorekac5 = PlayerPrefs.GetInt("carscore5");
        carscorekac6 = PlayerPrefs.GetInt("carscore6");
        carscorekac7 = PlayerPrefs.GetInt("carscore7");
        carscorekac8 = PlayerPrefs.GetInt("carscore8");

        esitlikicin = PlayerPrefs.GetInt("esiktik");
        esitlikicin1 = PlayerPrefs.GetInt("esiktik1");
        esitlikicin2 = PlayerPrefs.GetInt("esiktik2");
        esitlikicin3 = PlayerPrefs.GetInt("esiktik3");
        esitlikicin4 = PlayerPrefs.GetInt("esiktik4");
        esitlikicin5 = PlayerPrefs.GetInt("esiktik5");
        esitlikicin6 = PlayerPrefs.GetInt("esiktik6");
        esitlikicin7 = PlayerPrefs.GetInt("esiktik7");
        esitlikicin8 = PlayerPrefs.GetInt("esiktik8");




        slowlesayı = PlayerPrefs.GetInt("slowsay");
        uzaksan = PlayerPrefs.GetInt("uzaksa");

        formula1 =PlayerPrefs.GetInt("formula1");
        formula2 = PlayerPrefs.GetInt("formula2");
        formula3 = PlayerPrefs.GetInt("formula3");
        formula4 = PlayerPrefs.GetInt("formula4");
        formula5 = PlayerPrefs.GetInt("formula5");
        formula6 = PlayerPrefs.GetInt("formula6");
        formula7= PlayerPrefs.GetInt("formula7");
        formula8 = PlayerPrefs.GetInt("formula8");
        formula9 = PlayerPrefs.GetInt("formula9");
        formula10 = PlayerPrefs.GetInt("formula10");
        formula11 = PlayerPrefs.GetInt("formula11");
        formula12 = PlayerPrefs.GetInt("formula12");




    }


    void Update()
    {
        
        PlayerPrefs.SetInt("slowsay", slowlesayı);
        PlayerPrefs.SetInt("uzaksa", uzaksan);
        

        

        PlayerPrefs.SetInt("suluk", suluk);

        PlayerPrefs.SetInt("acılka1", acılka1);
        PlayerPrefs.SetInt("acılka2", acılka2);
        PlayerPrefs.SetInt("acılka3", acılka3);
        PlayerPrefs.SetInt("acılka4", acılka4);
        PlayerPrefs.SetInt("acılka5", acılka5);
        PlayerPrefs.SetInt("acılka6", acılka6);
        PlayerPrefs.SetInt("acılka7", acılka7);
        PlayerPrefs.SetInt("acılka8", acılka8);
        PlayerPrefs.SetInt("acılka9", acılka9);
       

        PlayerPrefs.SetInt("carscore",carscorekac);
        PlayerPrefs.SetInt("carscore1",carscorekac1);
        PlayerPrefs.SetInt("carscore2",carscorekac2);
        PlayerPrefs.SetInt("carscore3",carscorekac3);
        PlayerPrefs.SetInt("carscore4",carscorekac4);
        PlayerPrefs.SetInt("carscore5",carscorekac5);
        PlayerPrefs.SetInt("carscore6",carscorekac6);
        PlayerPrefs.SetInt("carscore7",carscorekac7);
        PlayerPrefs.SetInt("carscore8",carscorekac8);

        PlayerPrefs.SetInt("esiktik", esitlikicin);
        PlayerPrefs.SetInt("esiktik1", esitlikicin1);
        PlayerPrefs.SetInt("esiktik2", esitlikicin2);
        PlayerPrefs.SetInt("esiktik3", esitlikicin3);
        PlayerPrefs.SetInt("esiktik4", esitlikicin4);
        PlayerPrefs.SetInt("esiktik5", esitlikicin5);
        PlayerPrefs.SetInt("esiktik6", esitlikicin6);
        PlayerPrefs.SetInt("esiktik7", esitlikicin7);
        PlayerPrefs.SetInt("esiktik8", esitlikicin8);
        PlayerPrefs.SetInt("kapantının",kapantı);


        PlayerPrefs.SetInt("score", Score);
        ScoreText.text = "Score:" + Score;

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

        if (Score>PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore", Score);
            highscore.text ="High:"+Score.ToString();
        }

        if (slowlesayı == 0)
        {
        
            slowtus.SetActive(false);
        }
        if(uzaksan<3)
        {
            Score++;
        }

        if(kapantı==0)
        {
            Time.timeScale = 0;
            uzaksan = sa;
            PlayerPrefs.SetInt("uzaksa", uzaksan);

        }
        if(suluk==1)
        {
            tutorialmenu.SetActive(false);
            PlayerPrefs.SetInt("suluk", suluk);
        }

       
        

        if (Score % 400==399)
        {
            yolhızı += artır;
        }


        if (Score % 1400 == 1399)
        {
            slowlesayı += 1;
            slowgeldi.SetActive(true);
            slowtus.SetActive(true);
        }
        if (acılka1 == 0)
        {
            if (Score % carscorekac == 1999)
            {

                formula1 = 2;
                kazanma.SetActive(true);
                Kırmızısiyah.SetActive(true);

                esitlikicin = 8900000;
                carscorekac = 9000000;
                acılka1 += 1;
                PlayerPrefs.SetInt("acılka1", acılka1);
                PlayerPrefs.SetInt("esiktik", esitlikicin);
                PlayerPrefs.SetInt("carscore", carscorekac);

            }
        }
        if(acılka2==0)
        {
            if (Score % carscorekac1 == 3999)
            {
                formula2 = 3;
                kazanma.SetActive(true);
                beyazsiyah.SetActive(true);

                esitlikicin1 = 8900000;
                carscorekac1 = 9000000;
                acılka2 += 1;
                
                PlayerPrefs.SetInt("esiktik1", esitlikicin1);
                PlayerPrefs.SetInt("carscore1", carscorekac1);
                PlayerPrefs.SetInt("acılka2", acılka2);


            }
        }
        if(acılka3==0)
        {
            if (Score % carscorekac2 == 5199)
            {
                formula5 = 6;
                kazanma.SetActive(true);
                beyazkırmızı.SetActive(true);

                esitlikicin2 = 8900000;
                carscorekac2 = 9000000;
                acılka3 += 1;
                PlayerPrefs.SetInt("esiktik2", esitlikicin2);
                PlayerPrefs.SetInt("carscore2", carscorekac2);
                PlayerPrefs.SetInt("acılka3", acılka3);
            }
        }
        if(acılka4==0)
        {
            if (Score % carscorekac3 == 5999)
            {
                formula3 = 4;
                kazanma.SetActive(true);
                mavimorsarı.SetActive(true);

                esitlikicin3 = 8900000;
                carscorekac3 = 9000000;
                acılka4 += 1;
                PlayerPrefs.SetInt("esiktik3", esitlikicin3);
                PlayerPrefs.SetInt("carscore3", carscorekac3);
                PlayerPrefs.SetInt("acılka4", acılka4);
            }
        }
       if(acılka5==0)
        {
            if (Score % carscorekac4 == 6699)
            {
                formula4 = 5;
                kazanma.SetActive(true);
                morsarı.SetActive(true);

                esitlikicin4 = 8900000;
                carscorekac4 = 9000000;
                acılka5 += 1;
                PlayerPrefs.SetInt("esiktik4", esitlikicin4);
                PlayerPrefs.SetInt("carscore4", carscorekac4);
                PlayerPrefs.SetInt("acılka5", acılka5);
            }
        }
        if(acılka6==0)
        {
            if (Score % carscorekac5 == 7199)
            {
                formula7 = 8;
                kazanma.SetActive(true);
                beyazmavi.SetActive(true);

                esitlikicin5 = 8900000;
                carscorekac5 = 9000000;
                acılka6 += 1;
                PlayerPrefs.SetInt("esiktik5", esitlikicin5);
                PlayerPrefs.SetInt("carscore5", carscorekac5);
                PlayerPrefs.SetInt("acılka6", acılka6);
            }
        }
        if(acılka7==0)
        {
            if (Score % carscorekac6 == 7999)
            {
                formula12 = 13;
                kazanma.SetActive(true);
                beyazsiyahv2.SetActive(true);

                esitlikicin6 = 8900000;
                carscorekac6 = 9000000;
                acılka7 += 1;
                PlayerPrefs.SetInt("esiktik6", esitlikicin6);
                PlayerPrefs.SetInt("carscore6", carscorekac6);
                PlayerPrefs.SetInt("acılka7", acılka7);
            }
        }
        if (acılka8==0)
        {
            if (Score % carscorekac7 == 8999)
            {
                formula9 = 10;
                kazanma.SetActive(true);
                siyahsarı.SetActive(true);

                esitlikicin7 = 8900000;
                carscorekac7 = 9000000;
                acılka8 += 1;
                PlayerPrefs.SetInt("esiktik7", esitlikicin7);

                PlayerPrefs.SetInt("carscore7", carscorekac7);
                PlayerPrefs.SetInt("acılka8", acılka8);
            }
        }
        if(acılka9==0)
        {
            if (Score % carscorekac8 == 11999)
            {
                formula10 = 11;
                kazanma.SetActive(true);
                turuncumorbeyaz.SetActive(true);

                esitlikicin8 = 8900000;
                carscorekac8 = 9000000;
                acılka9 += 1;
                PlayerPrefs.SetInt("esiktik8", esitlikicin8);
                PlayerPrefs.SetInt("carscore8", carscorekac8);
                PlayerPrefs.SetInt("acılka9", acılka9);
            }
        }
        


        if (Score % özeltuzakgelmesayısı == 499)
        {
            int randsın = Random.Range(1, 3);
            int ortarand = 2;

           
            if (randsın == 2)
            {
                int sagrandsın = Random.Range(0, 5);

                if (sagrandsın == 1)
                {
                    sag1.SetActive(true);
                    if (bekleme1 > 0)
                    {
                        bekleme1 -= 5;
                    }
                    else
                    {

                        sag1.SetActive(false);
                        sag1.transform.position = new Vector2(1.15f, 8.92f);
                        
                        bekleme1 = 5;
                    }
                }
                if (sagrandsın == 2)
                {
                    sag2.SetActive(true);
                    if (bekleme2 > 0)
                    {
                        bekleme2 -= 5;
                    }
                    else
                    {

                        sag2.SetActive(false);
                        sag2.transform.position = new Vector2(1.15f, 8.92f);
                        bekleme2 = 5;
                    }
                }
                if (sagrandsın == 3)
                {
                    sag3.SetActive(true);
                    if (bekleme3 > 0)
                    {
                        bekleme3 -= 5;
                    }
                    else
                    {

                        sag3.SetActive(false);
                        sag3.transform.position = new Vector2(1.15f, 8.92f);
                        bekleme3 = 5;
                    }
                }
                if (sagrandsın == 4)
                {
                    sag4.SetActive(true);
                    if (bekleme4 > 0)
                    {
                        bekleme4 -= 5;
                    }
                    else
                    {

                        sag4.SetActive(false);
                        sag4.transform.position = new Vector2(1.15f, 8.92f);
                        bekleme4 = 5;
                    }
                }



            }

            if (ortarand == 2)
            {
                int ortarandsın = Random.Range(0, 5);

                if (ortarandsın == 1)
                {
                    orta1.SetActive(true);
                    if(bekleme5>0)
                    {
                        bekleme5 -= 5;
                    }
                    else
                    {
                        
                        orta1.SetActive(false);
                        orta1.transform.position = new Vector2(-0.59f, 8.92f);
                        bekleme5 = 5;
                    }
                }
                if (ortarandsın == 2)
                {
                    orta2.SetActive(true);
                    if (bekleme6 > 0)
                    {
                        bekleme6 -= 5;
                    }
                    else
                    {
                        
                        orta2.SetActive(false);
                        orta2.transform.position = new Vector2(-0.59f, 8.92f);
                        bekleme6 = 5;
                    }

                }
                if (ortarandsın == 3)
                {
                    orta3.SetActive(true);
                    if (bekleme7 > 0)
                    {
                        bekleme7 -= 5;
                    }
                    else
                    {
                        
                        orta3.SetActive(false);
                        orta3.transform.position = new Vector2(-0.59f, 8.92f);
                        bekleme7 = 5;
                    }
                }
                if (ortarandsın == 4)
                {
                    orta4.SetActive(true);
                    if (bekleme8 > 0)
                    {
                        bekleme8 -= 5;
                    }
                    else
                    {
                        
                        orta4.SetActive(false);
                        orta4.transform.position = new Vector2(-0.59f, 8.92f);
                        bekleme8 = 5;
                    }
                }
            }

            if (randsın == 1)
            {
                int solrandsın = Random.Range(0, 5);

                if (solrandsın == 1)
                {
                    sol1.SetActive(true);
                    if (bekleme9 > 0)
                    {
                        bekleme9 -= 5;
                    }
                    else
                    {

                        sol1.SetActive(false);
                        sol1.transform.position = new Vector2(-2.25f, 8.92f);
                        bekleme9 = 5;
                    }
                }
                if (solrandsın == 2)
                {
                    sol2.SetActive(true);
                    if (bekleme10 > 0)
                    {
                        bekleme10 -= 5;
                    }
                    else
                    {

                        sol2.SetActive(false);
                        sol2.transform.position = new Vector2(-2.25f, 8.92f);
                        bekleme10 = 5;
                    }
                }
                if (solrandsın == 3)
                {
                    sol3.SetActive(true);
                    if (bekleme11 > 0)
                    {
                        bekleme11 -= 5;
                    }
                    else
                    {

                        sol3.SetActive(false);
                        sol3.transform.position = new Vector2(-2.25f, 8.92f);
                        bekleme11 = 5;
                    }
                }
                if (solrandsın == 4)
                {
                    sol4.SetActive(true);
                    if (bekleme12 > 0)
                    {
                        bekleme12 -= 5;
                    }
                    else
                    {

                        sol4.SetActive(false);
                        sol4.transform.position = new Vector2(-2.25f, 8.92f);
                        bekleme12 = 5;
                    }
                }
            }
        }


        




    }

    public void tusbasgitsin()
    {
        Kırmızısiyah.SetActive(false);
       beyazsiyah.SetActive(false);
       mavimorsarı.SetActive(false);
       morsarı.SetActive(false);
        beyazkırmızı.SetActive(false);
       beyazmavi.SetActive(false);
       siyahsarı.SetActive(false);
        turuncumorbeyaz.SetActive(false);
        beyazsiyahv2.SetActive(false);
        slowgeldi.SetActive(false);
    }

    public void slowed()
    {

        
        yolhızı +=0.4f;
        slowlesayı -= 1;
        süre -= Time.deltaTime;
        
       
        
        PlayerPrefs.SetInt("slowsay", slowlesayı);

        Invoke("duzel", 8);

        



        if (slowlesayı==0)
        {
            slowtus.SetActive(false);
        }
    }
    public void duzel()
    {
        
        süre = 8;
        yolhızı -= 0.4f;
    }


    
    


}

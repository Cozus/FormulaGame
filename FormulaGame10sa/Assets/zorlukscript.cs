using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zorlukscript : MonoBehaviour
{
    public float yolhızlı;

    public int hardint;
    public int medint;
    public int normalint;

    public GameObject zorlukmenu;
    void Start()
    {
        yolhızlı = PlayerPrefs.GetFloat("hızcek");
        hardint = PlayerPrefs.GetInt("hardint");
        medint = PlayerPrefs.GetInt("medint");
        normalint = PlayerPrefs.GetInt("normalint");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("hızcek",yolhızlı);
        PlayerPrefs.SetInt("hardint", hardint);
        PlayerPrefs.SetInt("medint", medint);
        PlayerPrefs.SetInt("normalint", normalint);

        if(hardint==1)
        {
            yolhızlı =-4.6f;
            PlayerPrefs.SetFloat("hızcek", yolhızlı);
        }

        if(medint==1)
        {
            yolhızlı = -4f;
            PlayerPrefs.SetFloat("hızcek", yolhızlı);
        }
        if(normalint==1)
        {
            yolhızlı = -3.7f;
            PlayerPrefs.SetFloat("hızcek", yolhızlı);
        }
    }

    public void hardvod()
    {
        hardint += 1;
        medint = 0;
        normalint = 0;
        PlayerPrefs.SetInt("hardint", hardint);
        PlayerPrefs.SetInt("medint", medint);
        PlayerPrefs.SetInt("normalint", normalint);
    }

    public void medvod()
    {
        hardint = 0;
        medint += 1;
        normalint = 0;
        PlayerPrefs.SetInt("hardint", hardint);
        PlayerPrefs.SetInt("medint", medint);
        PlayerPrefs.SetInt("normalint", normalint);
    }

    public void normalvod()
    {
        hardint = 0;
        medint = 0;
        normalint += 1;
        PlayerPrefs.SetInt("hardint", hardint);
        PlayerPrefs.SetInt("medint", medint);
        PlayerPrefs.SetInt("normalint", normalint);
    }

    public void zorlukmenukapat()
    {
        zorlukmenu.SetActive(false);
    }

    public void zorlukmenuac()
    {
        zorlukmenu.SetActive(true);
    }
}

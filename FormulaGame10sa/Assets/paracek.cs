using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paracek : MonoBehaviour
{
    public int gelpara;
    public Text ParaText;
    
    void Start()
    {
        ParaText = GetComponent<Text>();
        Invoke("sa", 5);
    }

    
    void Update()
    {

        ParaText.text = "" + gelpara;
    }

    void sa()
    {
        gelpara += 20;
        Invoke("sa1", 15);
    }
    void sa1()
    {
        gelpara += 35;
        Invoke("sa2", 30);
    }
    void sa2()
    {
        gelpara += 35;
        Invoke("sa3", 55);
    }
    void sa3()
    {
        gelpara += 35;
        Invoke("sa4", 70);
    }
    void sa5()
    {
        gelpara += 35;
        Invoke("sa6", 105);
    }
    void sa6()
    {
        gelpara += 35;
        Invoke("sa7", 130);
    }
    void sa7()
    {
        gelpara += 45;
        Invoke("sa8", 175);
    }
    void sa8()
    {
        gelpara += 45;
        Invoke("sa9", 210);
    }
    void sa9()
    {
        gelpara += 35;
        Invoke("sa10", 265);
    }
    void sa10()
    {
        gelpara += 55;
        Invoke("sa11", 325);
    }
    void sa11()
    {
        gelpara += 45;
        Invoke("sa12", 380);
    }
    void sa12()
    {
        gelpara += 55;
        Invoke("sa11", 445);
    }
    void sa13()
    {
        gelpara += 55;
        Invoke("sa14", 500);
    }
    void sa14()
    {
        gelpara += 55;
        Invoke("sa15", 555);
    }
    void sa15()
    {
        gelpara += 55;
        Invoke("sa16", 610);
    }
    void sa16()
    {
        gelpara += 55;
        Invoke("sa17", 660);
    }
}

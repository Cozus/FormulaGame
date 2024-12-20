using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renksistem : MonoBehaviour
{
    public GameObject yesil;
    public GameObject pembe;
    public GameObject mavi;

    public int renkler;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (renkler == 1)
        {
            yesil.SetActive(false);
        }

        if (renkler == 2)
        {
            pembe.SetActive(false);
        }

        if (renkler == 3)
        {
            mavi.SetActive(false);
        }
    }

    public void yesiltus()
    {
        renkler = 1;
    }

    public void pembetus()
    {
        renkler = 2;
    }

    public void mavitus()
    {
        renkler = 3;
    }
}

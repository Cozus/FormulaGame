using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marketackapa : MonoBehaviour
{
    public GameObject Marketarka;
    public GameObject Marketarka2;
    public GameObject kapatmatus;
    public GameObject marketileritus;
    public GameObject marketgeritus;
    public GameObject marketsecmeseyleri;
    public GameObject marketsecmeseyleri2;
    public GameObject marketherseyaçdı;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void marketileri()
    {
        Marketarka2.SetActive(true);
        marketsecmeseyleri2.SetActive(true);
        marketgeritus.SetActive(true);

        Marketarka.SetActive(false);
        marketsecmeseyleri.SetActive(false);
        marketileritus.SetActive(false);

    }

    public void marketgeri()
    {
        Marketarka2.SetActive(false);
        marketsecmeseyleri2.SetActive(false);
        marketgeritus.SetActive(false);

        Marketarka.SetActive(true);
        marketsecmeseyleri.SetActive(true);
        marketileritus.SetActive(true);
    }

    public void marketkapat()
    {
        marketherseyaçdı.SetActive(false);
    }

    
}

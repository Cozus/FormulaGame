using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokol : MonoBehaviour
{
    public GameObject button;
    public GameObject logar;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void yoketlan()
    {
        button.SetActive(false);
        logar.SetActive(false);
    }
}

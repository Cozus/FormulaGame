using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tuzak : MonoBehaviour
{
    public GameObject f1;
    public GameObject tekraroyna;
    public GameObject scoretextinin;
    public AudioSource mysfx;
    public GameObject f1sler;
    public GameObject patmases;
 
   
 
    
    void Start()
    {
        mysfx = GetComponent<AudioSource>();
    }

    
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tekraroyna.SetActive(true);
        Time.timeScale = 0;
        f1.SetActive(false);
        patmases.SetActive(true);
        scoretextinin.SetActive(false);
        Time.timeScale = 0;
        f1sler.SetActive(false);
        f1.SetActive(false);
        

        
        
       
        Debug.Log("bendimopic");
    }

    public void sanmam()
    {
        
    }
}

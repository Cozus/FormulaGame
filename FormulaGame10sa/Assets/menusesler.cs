using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menusesler : MonoBehaviour
{
    public AudioClip aquafx;
    public AudioClip swipeses;
    public AudioSource sesfxsi;
    public GameObject kapatıcı;
    public GameObject acıcı;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void seslen()
    {
        sesfxsi.PlayOneShot(aquafx);
    }
    public void seslensi()
    {
        sesfxsi.PlayOneShot(swipeses);
    }

    public void sustu()
    {
        AudioListener.pause = true;
        acıcı.SetActive(true);
        kapatıcı.SetActive(false);
    }
    public void konustu()
    {
        AudioListener.pause = false;
        kapatıcı.SetActive(true);
        acıcı.SetActive(false);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nitrobasmak : MonoBehaviour
{
    public Collider2D f1collider;
    public Collider2D f2collider;
    public Collider2D f3collider;
    public Collider2D f4collider;
    public Collider2D f5collider;
    public Collider2D f6collider;
    public Collider2D f7collider;
    public Collider2D f8collider;
    public Collider2D f9collider;
    public Collider2D f10collider;
    public int nitrodepo;
    public int çıkar = 1;
   
    
    
    

    
    void Start()
    {
        
        
    }

    void Update()
    {
        nitrodepo = PlayerPrefs.GetInt("nitrosayısı");
    }

    public void nitrobastınmıcıkıs() {
        if(1<=nitrodepo)
        {

            f1collider.enabled = false;
            f2collider.enabled = false;
            f3collider.enabled = false;
            f4collider.enabled = false;
            f5collider.enabled = false;
            f6collider.enabled = false;
            f7collider.enabled = false;
            f8collider.enabled = false;
            f9collider.enabled = false;
            f10collider.enabled = false;
            nitrodepo -= çıkar;
            Invoke("acılsanısı", 5);

            PlayerPrefs.SetInt("nitrosayısı", nitrodepo);
        }
        

        
    }

    public void acılsanısı()
    {
        f1collider.enabled = true;
        f2collider.enabled = true;
        f3collider.enabled = true;
        f4collider.enabled = true;
        f5collider.enabled = true;
        f6collider.enabled = true;
        f7collider.enabled = true;
        f8collider.enabled = true;
        f9collider.enabled = true;
        f10collider.enabled = true;
        
    }
    
}

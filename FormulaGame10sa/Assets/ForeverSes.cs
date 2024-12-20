using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeverSes : MonoBehaviour
{
    public AudioSource myfx;
    public AudioSource dyermy;
    public AudioClip buttonfx;
    public AudioClip patlamasesfx;
    public AudioSource surelifx;
    public AudioClip gerisayımcıfx;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void sesButton()
    {
        myfx.PlayOneShot(buttonfx);
    }
    public void patlatmases()
    {
        dyermy.PlayOneShot(patlamasesfx);
    }

    public void surelises()
    {
        surelifx.PlayOneShot(gerisayımcıfx);
    }


}

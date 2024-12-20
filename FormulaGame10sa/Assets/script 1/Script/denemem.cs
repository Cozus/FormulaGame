using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denemem : MonoBehaviour
{

    public GameObject tuzaksı;
    public GameObject particem;
    public ParticleSystem benimpartim;
    public int paraartır;
    public AudioSource myyfx;
    public AudioClip patlamafx;
    
    
    void Start()
    {
        benimpartim.Stop();
    }

    
    void Update()
    {
        

    }

    private void OnMouseDown()
    {
        myyfx.PlayOneShot(patlamafx);
        tuzaksı.SetActive(false);
        particem.SetActive(true);
        benimpartim.Play();
        Destroy(particem,4.0f);
        
        


    }

    public void acınki()
    {
        
    }

    public void acılkanka()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sınırastınamasen : MonoBehaviour
{
    public GameObject particiler;
    
    void Start()
    {
        
    }

    
    void Update()
    {
      
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(particiler);
        Destroy(gameObject);
    }
}

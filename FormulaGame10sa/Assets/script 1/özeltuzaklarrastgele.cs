using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class özeltuzaklarrastgele : MonoBehaviour
{
    public GameObject[] özeltuzakns;
    

    void Start()
    {
        int randımana = Random.Range(0, özeltuzakns.Length);
        Instantiate(özeltuzakns[randımana], transform.position, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}

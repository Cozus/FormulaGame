using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsuzYol : MonoBehaviour
{
    public GameObject yol1;
    public GameObject yol2;

    float uzunluk = 0;
    void Start()
    {
        uzunluk = yol1.GetComponent<BoxCollider2D>().size.y;
    }

    
    void Update()
    {
        if(yol1.transform.position.y<=-uzunluk)
        {
            yol1.transform.position += new Vector3(0, uzunluk * 2);
        }

        if (yol2.transform.position.y <= -uzunluk)
        {
            yol2.transform.position += new Vector3(0, uzunluk * 2);
        }
    }
}

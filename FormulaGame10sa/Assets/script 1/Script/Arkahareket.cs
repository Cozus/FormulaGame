using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arkahareket : MonoBehaviour
{
    public GameObject yol1;
    public Hızısınırı hızsın;
    private float yolunhızsıfilan;
    

    Rigidbody2D fizik1;
  

    void Start()
    {
        

       
    }

   
    void Update()
    {
        fizik1 = yol1.GetComponent<Rigidbody2D>();
        yolunhızsıfilan = PlayerPrefs.GetFloat("hızcek");

        fizik1.velocity = new Vector2(0, yolunhızsıfilan);
    }

   
}

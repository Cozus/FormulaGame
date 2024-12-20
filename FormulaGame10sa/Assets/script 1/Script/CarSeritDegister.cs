using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSeritDegister : MonoBehaviour
{
    public float Carspeed;
    Vector3 posizyon;
    
    void Start()
    {
        posizyon = transform.position;
    }

    
    void Update()
    {
        posizyon.x += Input.GetAxis("Horizantel") * Carspeed * Time.deltaTime;
        transform.position = posizyon;
    }
}

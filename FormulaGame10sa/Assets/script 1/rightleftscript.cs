using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightleftscript : MonoBehaviour
{
    

    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    
    void Update()
    {
      //float Xposion = Mathf.Clamp(transform.position.x, -3.05f, 3.37f);
        //transform.position = new Vector3(Xposion, transform.position.y, transform.position.z);
    }

    public void soltus()
    {
        transform.position = new Vector3(transform.position.x -1.74f , transform.position.y, transform.position.z);
    }

    public void sagtus()
    {
        transform.position = new Vector3(transform.position.x + 1.74f, transform.position.y, transform.position.z);
    }
}

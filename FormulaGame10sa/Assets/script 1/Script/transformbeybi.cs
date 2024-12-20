using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformbeybi : MonoBehaviour
{
    
    public GameObject f1ye;
    void Start()
    {
        
    }


    private void OnMouseDown()
    {

        f1ye.transform.position = new Vector3(-1.83f, -1.79f,0);

    }
}

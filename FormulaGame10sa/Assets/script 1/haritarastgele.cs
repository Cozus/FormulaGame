using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haritarastgele : MonoBehaviour
{
    public GameObject buzlu;
    public GameObject kumlu;
    public GameObject duz;
    
    void Start()
    {
        int rastgelesec = Random.Range(1,4);

        if(rastgelesec==1)
        {
            kumlu.SetActive(true);
            buzlu.SetActive(false);
            duz.SetActive(false);
        }
        if (rastgelesec == 2)
        {
            kumlu.SetActive(false);
            buzlu.SetActive(true);
            duz.SetActive(false);
        }
        if (rastgelesec == 3)
        {
            kumlu.SetActive(false);
            buzlu.SetActive(false);
            duz.SetActive(true);
        }
    }

    

}

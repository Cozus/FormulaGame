using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nitro : MonoBehaviour
{
    public GameObject tuzak;
    public GameObject tuzak1;
    public GameObject tuzak2;
    public GameObject tuzak3;
    public GameObject tuzak4;
    public GameObject tuzak5;

    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
        
    

    public void nitrom()
    {
        tuzak.SetActive(false);
        tuzak1.SetActive(false);
        tuzak2.SetActive(false);
        tuzak3.SetActive(false);
        tuzak4.SetActive(false);
        tuzak5.SetActive(false);
    }
      
     IEnumerable test()
    {
        yield return new WaitForSeconds(3);

        tuzak.SetActive(true);
    }
}

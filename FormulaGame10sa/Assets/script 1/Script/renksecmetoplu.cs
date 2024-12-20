using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renksecmetoplu : MonoBehaviour
{
    public GameObject renksecme;
    public GameObject renkliserit;
    public GameObject renkseritfake;
    public GameObject kırmızıkasklar;
    public GameObject yesilkasklar;
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        renkliserit.SetActive(false);
        renkseritfake.SetActive(true);
        renksecme.SetActive(false);
        if(renksecme.tag=="yesilsecme")
        {
            yesilkasklar.SetActive(true);
            kırmızıkasklar.SetActive(false);
        }

        if (renksecme.tag == "kırmızısecme")
        {
            yesilkasklar.SetActive(false);
            kırmızıkasklar.SetActive(true);
        }



    }
}

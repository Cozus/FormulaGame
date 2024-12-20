using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialtuzakdeneme : MonoBehaviour
{
    public GameObject kendisiyoket;
    public int klavyeci;
    public GameObject particemyok;
    public ParticleSystem benimpartimyok;
    void Start()
    {
        klavyeci = PlayerPrefs.GetInt("klavye");
    }


    void Update()
    {
        PlayerPrefs.SetInt("klavye", klavyeci);

        if(klavyeci==1)
        {
            kendisiyoket.SetActive(false);
            particemyok.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        klavyeci += 1;
        PlayerPrefs.SetInt("klavye", klavyeci);
        kendisiyoket.SetActive(false);
        particemyok.SetActive(true);
        benimpartimyok.Play();
        Destroy(particemyok, 4.0f);
    }

    public void kavyedesil()
    {
        PlayerPrefs.DeleteKey("klavye");
    }
}

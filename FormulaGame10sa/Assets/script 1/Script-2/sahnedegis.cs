using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnedegis : MonoBehaviour
{
    public int sahnesayısı;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sahnedgister()
    {
        SceneManager.LoadScene(sahnesayısı);
    }
}

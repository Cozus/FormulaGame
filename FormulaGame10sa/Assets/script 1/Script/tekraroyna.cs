using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tekraroyna : MonoBehaviour
{
    public int sahnem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tekrardus()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sahnem);
    }
}

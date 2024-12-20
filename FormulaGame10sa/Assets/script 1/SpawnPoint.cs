using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] tuzakns;
    
    void Start()
    {
        int randıman = Random.Range(0, tuzakns.Length);
        Instantiate(tuzakns[randıman], transform.position, Quaternion.identity);

    }

    public void Update()
    {
        
    }



}

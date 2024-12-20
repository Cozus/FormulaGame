using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tuzaklar;

    private float timeBtwSpawn;
    public float StarttimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    
    void Start()
    {
      

    }

    
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, tuzaklar.Length);
            Instantiate(tuzaklar[rand], transform.position, Quaternion.identity);

            timeBtwSpawn = StarttimeBtwSpawn;

           if(StarttimeBtwSpawn>minTime)
            {
                StarttimeBtwSpawn -= decreaseTime;
            }
            

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}

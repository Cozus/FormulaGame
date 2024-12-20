using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class gerisayım : MonoBehaviour
{
    public float totalTime;

    public Text text;
    public string textin;

    private float minutes;
    private float seconds;

    [Header("==Event Timer==")]
    public bool useventTimer;
    public UnityEvent TimerEvent;

    public void Start()
    {
        
    }

    private void Update()
    {
        totalTime -= Time.deltaTime;

        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);

        text.text = minutes.ToString() + seconds.ToString();


        if(totalTime==0)
        {
            Time.timeScale = 1;
            text.text = textin;
        }
            
    }


}

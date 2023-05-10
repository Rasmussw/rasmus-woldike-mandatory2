using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeToPlay = 300;
    public TMP_Text showTime;

    public AudioSource src;
    public AudioClip whiselSound;
    

    // Update is called once per frame
    void Update()
    {
        if(timeToPlay > 0 )
        {
            timeToPlay -= Time.deltaTime; 
        } 
        else
        {
            //spillet skal stoppe her!!

            src.clip = whiselSound;
            src.Play();

            
        }

        float min = Mathf.FloorToInt(timeToPlay / 60);
        float sec = Mathf.FloorToInt(timeToPlay % 60);
        showTime.text = "TIME LEFT: " + min + ":" + sec;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public AudioSource src;
    public AudioClip goalSound;
    public ScoreScript sc;
    // Start is called before the first frame update
    void Start()
    {
        
    } 


    void OnCollisionEnter(Collision hit)
    {
        if(hit.transform.name == "Ball")
        {
            src.clip = goalSound;
            src.Play();
            sc.AddScore(1);

        }
    }
}

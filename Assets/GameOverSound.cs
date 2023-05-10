using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    public AudioSource src;
    public AudioClip whiselSound;
    // Start is called before the first frame update
    void Start()
    {
        src.clip = whiselSound;
        src.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

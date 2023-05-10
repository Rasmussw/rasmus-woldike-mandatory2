using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Transform reSpawnPoint;
    [SerializeField] float spawnVal;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.transform.name == "Cube (12)" || hit.transform.name == "Cube (13)")
        {
            RespawnPoint();
        }
    }

    void RespawnPoint()
    {
        transform.position = reSpawnPoint.position;
    }
}

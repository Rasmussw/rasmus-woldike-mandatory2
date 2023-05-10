using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnWhenHitOpponent : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Transform reSpawnPoint;
    [SerializeField] float spawnVal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.transform.name == "Cube (14)" || hit.transform.name == "Cube (15)" || hit.transform.name == "Cube (16)" || hit.transform.name == "Cube (17)")
        {
            RespawnPoint();
        }
    }

    void RespawnPoint()
    {
        transform.position = reSpawnPoint.position;
    }
}

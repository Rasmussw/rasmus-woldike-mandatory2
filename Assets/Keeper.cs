using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : MonoBehaviour
{
    public Vector3 position1 = new Vector3(48,1,6);
     public Vector3 position2 = new Vector3(48,1,-6);
    public float speed = 1;
    void Start()
 {
 }
 private void Update()
 {
    
        transform.position = Vector3.Lerp (position1, position2, Mathf.PingPong(Time.time*speed, 1.0f));
    
 
 }
}

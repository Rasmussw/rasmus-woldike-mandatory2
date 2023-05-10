using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fra dette link: https://gamedevbeginner.com/how-to-follow-the-player-with-a-camera-in-unity-with-or-without-cinemachine/

public class CameraFollowPlayer : MonoBehaviour
{


public Transform player;
public Vector3 offset = new Vector3(-20,20,-20);
private void Start()
{
    transform.rotation = Quaternion.Euler(35.264f, 45f, 0);
}
void LateUpdate()
{
    Vector3 target = new Vector3(player.position.x, 0, player.position.z) + offset;
    transform.position = target;
}


}

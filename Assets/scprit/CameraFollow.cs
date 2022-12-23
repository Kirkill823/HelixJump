using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
 public Player player;
    public Vector3 PlatformToCamera;
    public float speed;

    private void Update()
    {

        if (player.CurrentPlatform != null)
        {
            Vector3 TargetPosition = player.CurrentPlatform.transform.position + PlatformToCamera;
            transform.position = Vector3.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);
        }
        else return;
    }
}

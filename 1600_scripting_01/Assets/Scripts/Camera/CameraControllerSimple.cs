using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerSimple : MonoBehaviour
{
    public GameObject ThirdPersonPlayer;
    public GameObject Camera;
    public GameObject CameraFollowObj;
    public float CameraMoveSpeed = 120.0f;
  

    void Start()
    {
        Camera.transform.position -= ThirdPersonPlayer.transform.TransformVector(0,0,01);
    }

     void Update()
    {
        transform.LookAt(CameraFollowObj.transform);
     }

   
}



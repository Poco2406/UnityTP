using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public  GameObject player;
    public Transform target; 
    public Vector3 velocity = Vector3.zero; 
    
    [Range(0,1)]
    public float smoothTime;

    public Vector3 positionOffset; 
    
    private void Awake ()
    {
        target=GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate() 
    {
        Vector3 targetPosition = target.position + positionOffset ;
        transform.position=Vector3.SmoothDamp(transform.position,targetPosition, ref velocity, smoothTime);     
    }
}
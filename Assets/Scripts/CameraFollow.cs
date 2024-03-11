<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
<<<<<<< HEAD
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.35f;
   
    private void LateUpdate() {
        if(target == null) {
            return;
        }

        Vector3 nextPosition = new Vector3(
            target.position.x,
            target.position.y,
            transform.position.z
        );

        // transform.position = nextPosition;
        transform.position = Vector3.SmoothDamp(
            transform.position,
            nextPosition,
            ref velocity,
            smoothTime
        );
    }
}
=======
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
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b

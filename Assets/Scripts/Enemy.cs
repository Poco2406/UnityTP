using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public ContactPoint2D[] listContacts = new ContactPoint2D[1];

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            other.GetContacts(listContacts);
            //The player jumped on the top of the enemy
            if(listContacts[0].normal.y < -0.5f){
                Destroy(gameObject);
<<<<<<< HEAD
            } 
=======
            }
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
        }
    }
}
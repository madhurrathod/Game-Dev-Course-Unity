using System;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    
    // This method is called when the player collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Log the name of the collided object
        Debug.Log("Player collided with: " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by" + other.gameObject.name);
    }
    void OnTriggerExit(Collider other2){
        Debug.Log("Trigger Exited By" + other2.gameObject.name);
    }

}

// Video 4 link:- https://youtu.be/Hlc64uenHPM

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour 
{   
    public float speed;

    void Update()
    {
        float directInX = Input.GetAxis("Horizontal"); 
        float directInY = Input.GetAxis("Vertical");
        if(directInX != 0)
        {
           Vector3 changeX = new Vector3(directInX,0,0);
           transform.Translate(changeX * speed * Time.deltaTime); 
        //    transform.Rotate(changeX * speed * Time.deltaTime); 
        }
        if(directInY != 0)
        {
            Vector3 changeY = new Vector3(0,directInY,0);
            // transform.Rotate(changeY*speed*Time.deltaTime);
        }

        Vector3 changeZ = new Vector3(1f,0,1f);
        if(Input.GetKey(KeyCode.Q))
        {
            transform.localScale += changeZ * Time.deltaTime;
            // transform.Rotate(changeZ*speed*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-changeZ*speed*Time.deltaTime);   
        }
    }
}
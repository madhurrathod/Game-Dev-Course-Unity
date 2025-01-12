// Video 3 link:- https://youtu.be/NxRDaxDlfp0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        float horimove = Input.GetAxis("Horizontal");
        Vector3 hello = new Vector3(horimove, 0f, 0f);
        transform.Translate(hello * speed * Time.deltaTime);


     // similar functionality for up and down movement 
     // if possible rotaion , scaling 
    }
}
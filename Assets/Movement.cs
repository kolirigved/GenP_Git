using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce=100.0f;
    void FixedUpdate()
    {   

        if(Input.GetKey("s")){
            rb.AddForce(0,0,forwardforce*Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w")){
            rb.AddForce(0,0,-forwardforce*Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(forwardforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(-forwardforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}

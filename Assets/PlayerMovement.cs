using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float forwardForce = 500;
    public float sidewaysForce = 100;
    public float jumpForce = 5000;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // Fixed update is called based on physics and fps
    void FixedUpdate()
    {
        if (rigidBody)
        {
            //Input should be handled in update, and handled with stored variables like usual
            rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
            if (Input.GetKey("d"))
            {
                rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("space") && (Math.Round(this.rigidBody.velocity.y) == 0 && this.rigidBody.position.y >= 1 && this.rigidBody.position.y <= 1.5))
            {
                rigidBody.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
    }
}

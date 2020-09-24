using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public BoxCollider playerCollider;
    public BoxCollider groundCollider;

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
            if (Input.GetKey("space") && this.playerCollider.bounds.Intersects(this.groundCollider.bounds))
            {
                rigidBody.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
    }
}

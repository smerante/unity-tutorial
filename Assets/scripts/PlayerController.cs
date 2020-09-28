using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotateSpeed = 180f;
    public float moveSpeed = 10f;
    float gravity = -9.8f;
    public CharacterController characterController;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundCheckRadius = 0.4f;
    public LayerMask groundLayer;
    bool isGrounded;
    public float jumpHeight = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            this.transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            this.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            Vector3 moveDirection = transform.TransformDirection(Vector3.forward) * moveSpeed * Time.deltaTime;
            if (this.characterController)
            {
                this.characterController.Move(moveDirection);
            }
        }
        if (Input.GetKey("s"))
        {
            Vector3 moveDirection = transform.TransformDirection(-Vector3.forward) * moveSpeed * Time.deltaTime;
            if (this.characterController)
            {
                this.characterController.Move(moveDirection);
            }
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetKey("space") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity) * Time.deltaTime;
        }
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f * Time.deltaTime;
        }
        velocity.y += gravity*1.5f * Time.deltaTime * Time.deltaTime;
        characterController.Move(velocity);
    }

    private void FixedUpdate()
    {
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("ControllerColliderHit: " + hit.gameObject.name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision: " + collision.gameObject.name);
        Vector3 moveDirection = transform.TransformDirection(collision.rigidbody.velocity) * moveSpeed * Time.deltaTime;
        this.characterController.Move(moveDirection);
    }
}

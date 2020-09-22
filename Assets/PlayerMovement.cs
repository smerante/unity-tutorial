using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // Fixed update is called based on physics and fps
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, 500 * Time.deltaTime);
    }
}

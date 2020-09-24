using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovementScript;

    private void OnCollisionEnter(Collision collision)
    {
        // Check collisions for obstacles
        if(collision.collider.tag == "Obstacle")
        {
            this.playerMovementScript.enabled = false;
        }
    }
}

using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ 
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionData)
    {
        if (collisionData.collider.tag == "Obstacle")
        {
            Debug.Log(collisionData.collider.name);
            movement.enabled = false;
        }
    }
}

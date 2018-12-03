using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovements movements;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit something");
            movements.enabled = false;
        }
        
    }
}

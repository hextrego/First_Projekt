using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public v2MovementScript movements;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit something");
            movements.enabled = false;
        }
        
    }
}

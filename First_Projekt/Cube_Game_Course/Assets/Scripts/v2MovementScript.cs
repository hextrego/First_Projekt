using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class v2MovementScript : MonoBehaviour
{
    public Collision collisionInfo = new Collision();
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    private void Start()
    {
        // let the gameObject fall down
        gameObject.transform.position = new Vector3(0, 5, 0);
    }
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }
}
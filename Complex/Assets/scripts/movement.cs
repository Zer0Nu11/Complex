using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 velocity;

    public Transform groundCheck;
    public LayerMask Mask;
    void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * x + transform.forward * z + transform.up*0f;

        velocity.y -= 9.81f;

        if (Physics.CheckSphere(groundCheck.position, 0.5f, Mask))
        {
            velocity.y = -1f;
        }

        this.GetComponent<CharacterController>().Move(move * speed * Time.deltaTime);
        this.GetComponent<CharacterController>().Move(velocity * Time.deltaTime);
    }
}

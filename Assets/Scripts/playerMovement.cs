using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    private float speed = 2.5f;
    private float jumpHeight = 1.0f;
    private float gravity = -20.0f;
    private bool grounded;
    private bool doubleJump = false;

    public GameObject DeathScreen;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        grounded = controller.isGrounded;
        if (grounded && velocity.y < 0)
        {
            velocity.y = 0f;
            doubleJump = false;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if (Input.GetButton("Jump") && grounded)
        {
            Jump();
            doubleJump = true;
        }
        
        if (Input.GetButtonDown("Jump") && !grounded && doubleJump)
        {
            velocity.y = 0f;
            Jump();
            doubleJump = false;
        }

        if (this.gameObject.transform.position.y < -6)
        {
            Destroy(this.gameObject);
            DeathScreen.SetActive(true);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void Jump()
    {
        velocity.y += Mathf.Sqrt(jumpHeight * -2.5f * gravity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saulPlayer : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2D;
    private Vector2 moveVelocity;

    public float moveInput;

    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        moveVelocity = new Vector2(moveInput * speed, rb2D.velocity.y);
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + moveVelocity * Time.fixedDeltaTime);
    }
}

 


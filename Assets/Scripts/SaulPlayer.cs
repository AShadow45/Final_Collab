using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saulPlayer : MonoBehaviour
{
    public float speed;

    public float jumpForce;

    private Rigidbody2D rb2D;
    private Vector2 moveVelocity;

    public float moveInput;

    private bool isGrounded;
    public Transform groundCheck;

    public float checkRadius;
    public LayerMask whatIsGround;
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
        if(Input.GetKeyDown(KeyCode.Space)){
            rb2D.velocity = Vector2.up * jumpForce;
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        rb2D.MovePosition(rb2D.position + moveVelocity * Time.fixedDeltaTime);
    }
}

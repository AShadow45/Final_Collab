using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaulPlayer : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
       rb2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput * moveSpeed;
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + moveVelocity*Time.fixedDeltaTime); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchingScript : MonoBehaviour
{
    //access AreaEffector2D components
    public WindScript windS;

    public float moveSpeed;

    public float windSpeed;
    public float windSlowSpeed;
    public float windFastSpeed;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    //Affect WindScript Area Effector Comp.
    void Update()
    {
        Vector3 pos = transform.position;

        //wind control to imitate crouching
        if (Input.GetKey(KeyCode.A))
        {
            windS.ae2D.forceMagnitude = windSlowSpeed;
        }
        else
        {
            windS.ae2D.forceMagnitude = windSpeed;
        }

        //walk forward
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1 * moveSpeed, 0);
            windS.ae2D.forceMagnitude = windFastSpeed;
        }
    }
}

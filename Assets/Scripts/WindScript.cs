using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindScript : MonoBehaviour
{
    Rigidbody2D rb;
    public AreaEffector2D ae2D;
    public float moveAmount = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ae2D = GetComponent<AreaEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //loop wind across screen
        //transform.position.x < -10.0f
        rb.velocity = -transform.right * moveAmount;
    }



}

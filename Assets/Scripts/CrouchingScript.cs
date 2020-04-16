using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchingScript : MonoBehaviour
{
    //private Rigidbody2D rb;

    //access AreaEffector2D components
    public WindScript windS;
    
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }



    //Affect WindScript Area Effector Comp.
    void Update()
    {

        //wind control to imitate crouching
        if (Input.GetKey(KeyCode.A))
        {
            windS.ae2D.forceMagnitude = -2;
        }
        else
        {
            windS.ae2D.forceMagnitude = -6;
        }
    }
}

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
        if (Input.GetKey(KeyCode.A))
        {  
            Debug.Log("A is on");
            //windS.ae2D.forceMagnitude = 1;

            //rb.isKinematic = true;

        }
        else {
            
            Debug.Log("A is off");

            //rb.isKinematic = false;
        }
    }
}

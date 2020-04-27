using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaulGrounded : MonoBehaviour
{
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "Ground"){
           Player.GetComponent<SaulPlayer>().isGrounded = true;
       } 
    }

}

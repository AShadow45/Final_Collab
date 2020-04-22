using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchingScript : MonoBehaviour
{
    //access AreaEffector2D components
    public WindScript windS;
    public StartDahli startDahli;

    Animator anim;

    public float moveSpeed;

    public float windSpeed;
    public float windSlowSpeed;
    public float windFastSpeed;

    private Rigidbody2D rb;

    public bool skullIsTalking;
    public bool windIsFade;

    public AudioSource playerFoot;

    public AudioClip[] clips;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerFoot = GetComponent<AudioSource>();

        //player is mving from the start
        skullIsTalking = false;
    }

    //Affect WindScript Area Effector Comp.
    void Update()
    {
        Vector3 pos = transform.position;
    
            //wind control to imitate crouching
            if (Input.GetKey(KeyCode.A))
            {
                windS.ae2D.forceMagnitude = windSlowSpeed;
                anim.SetTrigger("Crouching");
            }
            else
            {
                windS.ae2D.forceMagnitude = windSpeed;
                //anim.SetTrigger("Idle");
            }

        //moving controls
        if (Input.GetKey(KeyCode.D))
        {
            windS.ae2D.forceMagnitude = windFastSpeed;
            Debug.Log("Pressing D");
            anim.SetTrigger("Walking");
            rb.velocity = new Vector2(1 * moveSpeed, 0);

        }
        else
        {
            anim.SetTrigger("Idle");
        }

    }

    public void Step() {
        playerFoot.clip = clips[Random.Range(0, clips.Length)];
        playerFoot.Play();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("endtrigger")) {
            //the wind has stopped
            Debug.Log("Collided with End");
            collision.GetComponent<Collider2D>().enabled = false;
            windIsFade = true;
        }

    }
}

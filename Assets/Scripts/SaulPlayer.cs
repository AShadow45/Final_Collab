using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaulPlayer : MonoBehaviour {
public float moveSpeed;

public bool isGrounded = false;

public float jumpForce;

    public bool gameIsPaused = true;

    private Animator anim;

    private AudioSource audioS;

    //public AudioClip kidCheer;
    public AudioClip jump;

    public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameIsPaused)
        {
            Jump();
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * moveSpeed;

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                //play sound
                anim.SetTrigger("Walking");
            }
            else
            {
                anim.SetTrigger("Idle");
            }
        }
    }

    void Jump(){
        if(Input.GetButtonDown("Jump") && isGrounded == true){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            //play jumpin anim
            anim.SetTrigger("Jumping");

        isGrounded = false;
        }
    }

    public void Step()
    {
        audioS.clip = clips[Random.Range(0, clips.Length)];
        audioS.Play();
    }

    public void JumpSound() {
        audioS.clip = jump;
        audioS.Play();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove3D : MonoBehaviour
{
    private AudioSource audioS;
    public AudioClip[] clips;

    private Animator anim;

    public CharacterController controller;

    public float speed = 12f;
    // Start is called before the first frame update
    // Update is called once per frame

    void Start()
    {
        audioS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.anyKey)
        {
            //play sound
            anim.SetTrigger("Walking");
        } else {
            anim.SetTrigger("Idle");
        }
    }

    void FootSteps() {
        audioS.clip = clips[Random.Range(0, clips.Length)];
        audioS.Play();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove3D : MonoBehaviour
{
    private AudioSource audioS;
    public AudioClip[] clips;

    private Animator anim;

    public CharacterController controller;

    public float speed = 12f;

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

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
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

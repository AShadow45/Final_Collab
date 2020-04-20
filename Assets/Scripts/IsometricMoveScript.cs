﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricMoveScript : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4f;

    Vector3 forward, right;

    //detecting corners
    public bool playerIsCorner1;
    public bool playerIsCorner2;
    public bool playerIsCorner3;
    public bool playerIsCorner4;

    void Start()
    {

        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);

        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            Move();
        }
    }

    void Move() {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.up = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("1")) {
            Debug.Log("player is in 1");
            playerIsCorner1 = true;

            playerIsCorner2 = false;
            playerIsCorner3 = false;
            playerIsCorner4 = false;


        } 

        if (other.gameObject.CompareTag("2")) {
            Debug.Log("player is in 2");
            playerIsCorner2 = true;

            playerIsCorner1 = false;
            playerIsCorner3 = false;
            playerIsCorner4 = false;
        }

        if (other.gameObject.CompareTag("3")) {
            Debug.Log("player is in 3");
            playerIsCorner3 = true;

            playerIsCorner2 = false;
            playerIsCorner1 = false;
            playerIsCorner4 = false;
        }

        if (other.gameObject.CompareTag("4")) {
            Debug.Log("player is in 4");
            playerIsCorner4 = true;

            playerIsCorner2 = false;
            playerIsCorner3 = false;
            playerIsCorner1 = false;
        }
    }
}

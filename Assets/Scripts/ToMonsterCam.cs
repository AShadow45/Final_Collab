﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMonsterCam : MonoBehaviour
{
    private AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            audioS.Play();

        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMonet : MonoBehaviour
{
    public GameObject whiteF;
    private AudioSource audioS;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            //white set active
            whiteF.SetActive(true);

            //play sound
            audioS.Play();

            //start to museum
            StartCoroutine(WaitSecToMuseum());

        }
        
    }

    IEnumerator WaitSecToMuseum()
    {

        yield return new WaitForSeconds(1.7f);
        SceneManager.LoadScene("Biotanical");

    }
}

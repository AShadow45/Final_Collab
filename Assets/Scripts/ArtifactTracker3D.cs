﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactTracker3D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Artifact"){
            ArtifactTracker.score++;
            Debug.Log(ArtifactTracker.score);
        }
        
    }
}

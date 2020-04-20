using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactTracker : MonoBehaviour
{
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Artifact"){
            score++;
            Debug.Log(score);
        }
    }
}

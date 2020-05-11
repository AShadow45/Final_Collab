using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaulArtifactSound : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            audioS.Play();
        }
    }
}

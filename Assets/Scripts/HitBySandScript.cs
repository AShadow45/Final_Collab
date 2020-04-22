using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBySandScript : MonoBehaviour
{
    private AudioSource sandSource;
    public AudioClip flapSound;

    // Start is called before the first frame update
    void Start()
    {
        sandSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wind"))
        {
            //play flapping sound
            sandSource.clip = flapSound;
            sandSource.Play();
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wind"))
        {
            sandSource.Stop();

        }
    }
}

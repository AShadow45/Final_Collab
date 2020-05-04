using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaulArtifactScript : MonoBehaviour
{
    public SaulPlayer saulP;

    private AudioSource audioS;
    public AudioClip kidCheer;

    public GameObject conffetti;

    public GameObject endSaul;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            //play sound
            audioS.clip = kidCheer;
            audioS.Play();
            this.GetComponent<Collider2D>().enabled = false;

            //confetti
            conffetti.SetActive(true);

            //start enddialogue. set active
            endSaul.SetActive(true);

            //don't move
            saulP.gameIsPaused = true;
        }
    }
}

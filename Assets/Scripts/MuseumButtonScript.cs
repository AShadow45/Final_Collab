using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumButtonScript : MonoBehaviour
{  
    public GameObject whiteFade;

    private AudioSource audioS;

    public void LoadMuseum() {
        SceneManager.LoadScene("Museum");
        
    }

    private void Start()
    {
        whiteFade.SetActive(false);
        audioS = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            audioS.Play();
            StartCoroutine(WaitSecToMuseum());
            whiteFade.SetActive(true);

        }
    }

    IEnumerator WaitSecToMuseum() {

        yield return new WaitForSeconds(2.5f);
        LoadMuseum();
        
    }
}

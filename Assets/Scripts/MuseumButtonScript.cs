using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumButtonScript : MonoBehaviour
{
    public GameObject whiteFade;
    public bool objectGet = false;
   // public GameObject whiteLight;
    //public GameObject greenLight;

    public void LoadMuseum() {
        SceneManager.LoadScene("Museum");
       // whiteLight.SetActive(false);
       // greenLight.SetActive(true);
    }

    private void Start()
    {
        whiteFade.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            StartCoroutine(WaitSecToMuseum());
            whiteFade.SetActive(true);
            objectGet = true;
            //specify location in front of painting
        }
    }

    IEnumerator WaitSecToMuseum() {
        yield return new WaitForSeconds(3f);
        LoadMuseum();
        
    }
}

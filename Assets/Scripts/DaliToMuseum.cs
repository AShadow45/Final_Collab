using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DaliToMuseum : MonoBehaviour
{
    public GameObject whiteFade;
    //public GameObject gameManager;

  
    public void LoadMuseum() {
        SceneManager.LoadScene("Museum");
        
    }

    private void Start()
    {
        whiteFade.SetActive(false);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            //We found it...yay
           //gameManager.GetComponent<GameManagerDali>().found();
            StartCoroutine(WaitSecToMuseum());
            whiteFade.SetActive(true);

            //specify location in front of painting
        }
    }

    IEnumerator WaitSecToMuseum() {

        yield return new WaitForSeconds(3f);
        LoadMuseum();
        
    }
}


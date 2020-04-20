using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumButtonScript : MonoBehaviour
{
    public GameObject whiteFade;
    public GameObject gameManager;

  
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
           gameManager.GetComponent<GameManagerMonet>().found();
            StartCoroutine(WaitSecToMuseum());
            whiteFade.SetActive(true);

            //specify location in front of painting
        }
    }

    IEnumerator WaitSecToMuseum() {
            //saving to global so it doesn't get destroyed with scene
        gameManager.GetComponent<GameManagerMonet>().saveData();
        yield return new WaitForSeconds(3f);
        LoadMuseum();
        
    }
}

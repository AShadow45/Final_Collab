using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscherToMuseum : MonoBehaviour
{
    public GameObject whiteFade;
    //public GameObject gameManager;


    public void LoadMuseum()
    {
        SceneManager.LoadScene("Museum");

    }

    private void Start()
    {
        whiteFade.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            StartCoroutine(WaitSecToMuseum());
            whiteFade.SetActive(true);

            Debug.Log("player has entered artifact");
        }
    }

    IEnumerator WaitSecToMuseum()
    {

        yield return new WaitForSeconds(3f);
        LoadMuseum();

    }
}

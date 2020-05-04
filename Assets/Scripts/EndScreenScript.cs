using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{

    public GameObject whiteFade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //start corotine
            StartCoroutine(WaitSecToEnd());

            //white fade starts
            whiteFade.SetActive(true);
        }
    }

    void GoToWin() {
        // go to end scene
        SceneManager.LoadScene("Win");

    }

    IEnumerator WaitSecToEnd()
    {
        yield return new WaitForSeconds(3f);
        GoToWin();
    }
}

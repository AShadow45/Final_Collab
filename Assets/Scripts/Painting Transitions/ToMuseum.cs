using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMuseum : MonoBehaviour
{
    public GameObject whiteF;
    private AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player"){
            //white set active
            whiteF.SetActive(true);

            //play sound
            audioS.Play();

            //start to museum
            StartCoroutine(WaitSecToMuseum());
       } 
    }

    IEnumerator WaitSecToMuseum()
    {

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Museum");

    }
}

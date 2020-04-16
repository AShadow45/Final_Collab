using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEscher : MonoBehaviour
{
    // Start is called before the first frame update
    //this is for Escher transition
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            SceneManager.LoadScene("MC Escher");
        }
        
    }
}

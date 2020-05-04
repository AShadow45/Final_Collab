using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDali : MonoBehaviour
{
    public GameObject Player;
    //public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            //will save state to global before scene transition
            //gameManager.GetComponent<PlayerData>().SavetoGlobal();
            //player stays in place in museum
            //DontDestroyOnLoad(other.gameObject);

            SceneManager.LoadScene("Salvador Dahli");
            DontDestroyOnLoad(Player);

        }
    }
}

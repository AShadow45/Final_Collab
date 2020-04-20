using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetLight : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.GetComponent<PlayerData>().thingsFound.foundMonet){
            this.GetComponent<Light>().color = Color.green;
        }else{
            this.GetComponent<Light>().color = Color.white;
        }
    }
}

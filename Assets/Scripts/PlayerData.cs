using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
  //tracks what player has found so far
   public bool foundMonet = false;
   public bool foundSaul = false;

   public GameObject MonetWhite;
   public GameObject MonetGreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(foundMonet == true){
          MonetGreen.gameObject.SetActive(true);
          MonetWhite.gameObject.SetActive(false);
        }
    }
}

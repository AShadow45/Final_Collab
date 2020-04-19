using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetLight : MonoBehaviour
{
    public GameObject whiteLight;
    public GameObject greenLight;

    public MuseumButtonScript MuseumButton;
    // Start is called before the first frame update
    void Start()
    {
        MuseumButton = GetComponent<MuseumButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
     if(MuseumButton.objectGet == true){
         whiteLight.SetActive(false);
         greenLight.SetActive(true);
     }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMonet : MonoBehaviour
{
    public ThingsFound thingsFound;

    // Start is called before the first frame update
    void Start()
    {
     //previous scene pushed thingsfound to global, pulled into local here
        thingsFound = GlobalControl.Instance.thingsFound;   
    }

    public void found(){
        //We found it...yay
            thingsFound.foundMonet = true;
    }

    // Update is called once per frame
    public void saveData(){
        GlobalControl.Instance.thingsFound = thingsFound;   
    }
}

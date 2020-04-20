using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    public ThingsFound thingsFound ;

 
    // Start is called before the first frame update
    void Start()
    {
        //took thingsfound from GlobalControl and stores locally
        thingsFound = GlobalControl.Instance.thingsFound;
        if(thingsFound == null){
             Debug.Log("Dun gufed");
        }else{
            Debug.Log("Safe");  
        }
    }

//between scene transitions, save any info changed to global so next scene can pull
    public void SavetoGlobal(){
        GlobalControl.Instance.thingsFound = thingsFound;
    }
}

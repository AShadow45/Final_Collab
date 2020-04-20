using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* This is used to transfer data between scenes. When we "leave" a scene, we are going to set this
and flag it as "DontDestroyOnLoad". This will ensure that the object survives when the old scene is deleted.
In the "start" of the new scene, we can retrieve this object, and save it into the Player object of the scene

For this to work, all the Player objects must have a place where they can store the data we are holding here

We are going to store the list of pictures found so far.

we are using one object to store all the information, so we can copy it in one step. However, this object needs to 
be "serializable" so that it can be transfered between scenes.

We are going to use "ThingsFound" to store the list of pictures, and this will be serializable

 */
public class GlobalControl : MonoBehaviour
{
    // This holds the instace of Game Controller that is passed between scenes. 
    public static GlobalControl Instance;

    // This stores the list of things found in one scene, so it can be retrieved in the next sceene
    //the first time it creates a new instance.  All "artifacts found" are false
    public ThingsFound thingsFound = new ThingsFound(); 

    void Awake ()   
       {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
      }
}

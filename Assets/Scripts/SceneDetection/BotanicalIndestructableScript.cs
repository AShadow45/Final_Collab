using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotanicalIndestructableScript : MonoBehaviour
{
    public static BotanicalIndestructableScript instance = null;

    // For sake of example, assume -1 indicates first scene
    public int prevScene = -1;

    //save the scene number in the Indestructable object
    public int sceneNumber;

    void Awake()
    {

        // If we don't have an instance set - set it now
        if (!instance)
            instance = this;
        // Otherwise, its a double, we dont need it - destroy
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
        
    }

    void Update()
    {
        //if the player is in botanical scene, sceneNum is 1
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical")) {
            sceneNumber = 1;

            prevScene = sceneNumber;
        }        
        
        //if the player is in botanical scene, sceneNum is 2
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli")) {
            sceneNumber = 2;

            prevScene = sceneNumber;
        }        
        
        //if the player is in botanical scene, sceneNum is 3
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher2")) {
            sceneNumber = 3;

            prevScene = sceneNumber;
        }        
        
        //if the player is in botanical scene, sceneNum is 4
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul")) {
            sceneNumber = 4;

            prevScene = sceneNumber;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indestructable : MonoBehaviour
{

    public static Indestructable instance = null;

    //represents the first scene, the scene before
    public int prevScene;
    public int sceneNum;

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

    void Start()
    {
        sceneNum = prevScene;
    }

    void Update()
    {
        //Label scenes by number
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")){
            sceneNum = 0;
            Debug.Log("Museum is 0");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical")) {
            sceneNum = 1;
            Debug.Log("Botanical is 1");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli")) {
            sceneNum = 2;
            Debug.Log("Dali is 2");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher2")) {
            sceneNum = 3;
            Debug.Log("Escher is 3");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul")) {
            sceneNum = 4;
            Debug.Log("Saul is 4");
        }

    }

}

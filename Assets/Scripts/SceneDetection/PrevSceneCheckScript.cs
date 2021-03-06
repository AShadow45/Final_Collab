﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrevSceneCheckScript : MonoBehaviour
{
    public static PrevSceneCheckScript instance = null;

    public BotanicalIndestructableScript botanicalIndes;

    //effects empty object placeholders
    public GameObject botanicalEffects;
    public GameObject daliEffects;
    public GameObject escherEffects;
    public GameObject saulEffects;
    public GameObject dailyBlock;
    public GameObject dailyCanvas;

    public GameObject WinDoor;

    public GameObject exitCanvas;

    public bool botanicalIsUnlocked;
    public bool daliIsUnlocked;
    public bool escherIsUnlocked;
    public bool saulIsUnlocked;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if the player is in other scenes turn botanical off
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical"))
        {

            botanicalEffects.SetActive(false);
        }

        //if player was in botanical scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 1 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum"))
        {
            //have the effects appear
            botanicalEffects.SetActive(true);
            //save it, if this is true, the effects will be active in museum
            botanicalIsUnlocked = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        //if the player is in other scenes turn dali off
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli"))
        {

            daliEffects.SetActive(false);
        }

        //if player was in dali scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 2 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            daliEffects.SetActive(true);
            //save it, if this is true, the effects will be active in museum
            daliIsUnlocked = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        //if the player is in other scenes turn escher off
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3"))
        {

            escherEffects.SetActive(false);
        }

        //if player was in escher scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 3 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            escherEffects.SetActive(true);
            //save it, if this is true, the effects will be active in museum
            escherIsUnlocked = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        //if the player is in other scenes turn saul off
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul"))
        {

            saulEffects.SetActive(false);
        }

        //if player was in saul scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 4 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            saulEffects.SetActive(true);
            //save it, if this is true, the effects will be active in museum
            saulIsUnlocked = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        //if the player is in other scenes turn block off
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul"))
        {
            dailyBlock.SetActive(false);
            dailyCanvas.SetActive(false);
        } else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum"))
        {
            //block is active
            dailyBlock.SetActive(true);

        }

        if (botanicalIsUnlocked && daliIsUnlocked && escherIsUnlocked && saulIsUnlocked && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum"))
        {
            dailyBlock.SetActive(false);
            dailyCanvas.SetActive(true);
        }
        else {
            dailyCanvas.SetActive(false);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Biotanical") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul"))
        {
            exitCanvas.SetActive(true);

        } else {
            exitCanvas.SetActive(false);
        }
    }
}

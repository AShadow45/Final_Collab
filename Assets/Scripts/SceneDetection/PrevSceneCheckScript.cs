using System.Collections;
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
        //if player was in botanical scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 1 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            botanicalEffects.SetActive(true);

            //if the player is in other scenes turn it off
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Salvador Dahli") ||
                SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MC Escher3") ||
                SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Peter Saul"))
            {

                botanicalEffects.SetActive(false);
            } else {
                botanicalEffects.SetActive(true);

            }
        }        
        
        //if player was in dali scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 2 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            daliEffects.SetActive(true);
        }        
        
        //if player was in escher scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 3 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            escherEffects.SetActive(true);
        }        
        
        //if player was in saul scene, and prevNum = sceneNum, and player is back in museum
        if (botanicalIndes.prevScene == 4 && botanicalIndes.prevScene == botanicalIndes.sceneNumber && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            //have the effects appear
            saulEffects.SetActive(true);
        }
    }
}

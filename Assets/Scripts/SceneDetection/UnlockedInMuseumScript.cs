using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockedInMuseumScript : MonoBehaviour
{
    //check to see if unlocked bool is true and if player is in museum, effects will appear but not in other scenes

    public static UnlockedInMuseumScript instance = null;

    public PrevSceneCheckScript prevS;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        //botanical unlock
        if (prevS.botanicalIsUnlocked && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            prevS.botanicalEffects.SetActive(true);
        }

        //dali unlock
        if (prevS.daliIsUnlocked && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            prevS.daliEffects.SetActive(true);
        }

        //escher unlock
        if (prevS.escherIsUnlocked && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            prevS.escherEffects.SetActive(true);
        }

        //saul unlock
        if (prevS.saulIsUnlocked && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Museum")) {
            prevS.saulEffects.SetActive(true);
        }
    }
}

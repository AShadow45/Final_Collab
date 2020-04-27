using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToTraining : MonoBehaviour
{
    // Start is called before the first frame update
    public void toTutorial(){
        SceneManager.LoadScene("Tutorial");
    }
}

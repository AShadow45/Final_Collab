using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumButtonScript : MonoBehaviour
{
    public void LoadMuseum() {
        SceneManager.LoadScene("Museum");
    }
}

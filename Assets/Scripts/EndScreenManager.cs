using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToMuseum() {
        SceneManager.LoadScene("Museum");
        Debug.Log("To muse");

    }

    public void ToQuit() {
        Application.Quit();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscherToMuseum : MonoBehaviour
{
    public void LoadMuseum()
    {
        SceneManager.LoadScene("Museum");

    }

    void Start()
    {
        //starts when object is set active
        StartCoroutine(WaitSecToMuseum());
    }

    IEnumerator WaitSecToMuseum()
    {

        yield return new WaitForSeconds(6);
        LoadMuseum();

    }
}

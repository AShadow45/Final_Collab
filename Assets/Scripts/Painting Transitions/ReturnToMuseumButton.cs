using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMuseumButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnToMuseum()
    {
        SceneManager.LoadScene("Museum");
    }
}

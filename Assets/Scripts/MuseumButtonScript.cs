using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumButtonScript : MonoBehaviour
{
    public void LoadMuseum() {
        SceneManager.LoadScene("Museum");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            LoadMuseum();
            //specify location in front of painting
        }
    }
}

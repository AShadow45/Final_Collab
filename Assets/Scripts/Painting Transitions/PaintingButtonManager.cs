using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintingButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMonet() {
        SceneManager.LoadScene("Biotanical");
    }

    public void ToDahli() {
        SceneManager.LoadScene("Salvador Dahli");
    }

    public void ToEscher() {
        SceneManager.LoadScene("MC Escher (Copy)");
    }

    public void ToSaul() {
        SceneManager.LoadScene("Peter Saul");
    }
}

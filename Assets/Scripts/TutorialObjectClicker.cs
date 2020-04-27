using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialObjectClicker : MonoBehaviour
{
    public GameObject plaqueInteractTutorial;

    public GameObject plaqueTutorial;

    public GameObject museumPainting;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //tutorial bitmap layer
        int tutorial = 1 << 14;

        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //monet
        if (Physics.Raycast(ray, out hit, 100f, tutorial))
        {
            if (hit.transform != null)
            {
                //have UI text appear, click to interact
                plaqueInteractTutorial.SetActive(true);

                if (Input.GetMouseButton(0))
                {
                    //UI Plaque activated
                    plaqueTutorial.SetActive(true);

                    //show cursor
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                    museumPainting.SetActive(true);

                }
            }

        }
        else
        {
            plaqueInteractTutorial.SetActive(false);
        }
    }

    public void CloseTutorial()
    {
        plaqueTutorial.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

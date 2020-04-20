using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public GameObject plaqueInteractMonet;
    public GameObject plaqueInteractDahli;
    public GameObject plaqueInteractEscher;
    public GameObject plaqueInteractSaul;

    public GameObject plaqueMonet;
    public GameObject plaqueDahli;
    public GameObject plaqueEscher;
    public GameObject plaqueSaul;

    // Update is called once per frame
    void Update()
    {
        //bitmap of layers
        int monet = 1 << 9;
        int dahli = 1 << 10;
        int escher = 1 << 11;
        int saul = 1 << 12;

        RaycastHit hit;

        //turn screenpoint to ray, from cam to mousePos based on camera direction
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //monet
            if (Physics.Raycast(ray, out hit, 100f, monet))
            {
                if (hit.transform != null)
                {
                    //have UI text appear, click to interact
                    plaqueInteractMonet.SetActive(true);

                    if (Input.GetMouseButton(0)) {
                        //UI Plaque activated
                        plaqueMonet.SetActive(true);
                    }
                }

            } else {
                plaqueInteractMonet.SetActive(false);
            }

            //dahli
            if (Physics.Raycast(ray, out hit, 100f, dahli))
            {
                if (hit.transform != null)
                {
                    //have UI text appear, click to interact
                    plaqueInteractDahli.SetActive(true);

                    if (Input.GetMouseButton(0)) {
                        //UI Plaque activated
                        plaqueDahli.SetActive(true);
                    }
                }

            } else {
                plaqueInteractDahli.SetActive(false);
            }

            //escher
            if (Physics.Raycast(ray, out hit, 100f, escher))
            {
                if (hit.transform != null)
                {
                    //have UI text appear, click to interact
                    plaqueInteractEscher.SetActive(true);

                    if (Input.GetMouseButton(0)) {
                        //UI Plaque activated
                        plaqueEscher.SetActive(true);
                    }
                }

            } else {
                plaqueInteractEscher.SetActive(false);
            }

            //saul
            if (Physics.Raycast(ray, out hit, 100f, saul))
            {
                if (hit.transform != null)
                {
                    //have UI text appear, click to interact
                    plaqueInteractSaul.SetActive(true);

                    if (Input.GetMouseButton(0)) {
                        //UI Plaque activated
                        plaqueSaul.SetActive(true);
                    }
                }

            } else {
                plaqueInteractSaul.SetActive(false);
            }

    }

    void PrintName(GameObject click) {
        print(click.name);
    }

    public void CloseMonet() {
        plaqueMonet.SetActive(false);
    }

    public void CloseDahli() {
        plaqueDahli.SetActive(false);
    }

    public void CloseEscher() {
        plaqueEscher.SetActive(false);
    }

    public void CloseSaul() {
        plaqueSaul.SetActive(false);
    }
}

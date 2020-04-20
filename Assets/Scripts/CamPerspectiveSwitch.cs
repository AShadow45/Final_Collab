using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPerspectiveSwitch : MonoBehaviour
{
    public IsometricMoveScript playerScript;

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;

    //Wall Perspectives
    public GameObject wallPerspective1;
    public GameObject wallPerspective2;
    public GameObject wallPerspective3;
    public GameObject wallPerspective4;

    //moving to target
    /*
    public Transform Perspective1;
    public Transform Perspective2;
    public Transform Perspective3;
    public Transform Perspective4;
    */

    // Start is called before the first frame update
    void Start()
    {
        wallPerspective1.SetActive(false);
        wallPerspective2.SetActive(false);
        wallPerspective3.SetActive(false);
        wallPerspective4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.playerIsCorner1) {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;

            wallPerspective1.SetActive(true);
            wallPerspective4.SetActive(true);
            wallPerspective2.SetActive(false);
            wallPerspective3.SetActive(false);
        }

        if (playerScript.playerIsCorner2) {
            cam2.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;

            wallPerspective1.SetActive(true);
            wallPerspective2.SetActive(true);
            wallPerspective3.SetActive(false);
            wallPerspective4.SetActive(false);
        }

        if (playerScript.playerIsCorner3) {
            cam3.enabled = true;
            cam2.enabled = false;
            cam1.enabled = false;
            cam4.enabled = false;

            wallPerspective2.SetActive(true);
            wallPerspective3.SetActive(true);
            wallPerspective1.SetActive(false);
            wallPerspective4.SetActive(false);
        }

        if (playerScript.playerIsCorner4) {
            cam4.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;

            wallPerspective3.SetActive(true);
            wallPerspective4.SetActive(true);
            wallPerspective1.SetActive(false);
            wallPerspective2.SetActive(false);
        }


    }
}

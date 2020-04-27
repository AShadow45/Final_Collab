using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPerspectiveSwitch : MonoBehaviour
{
    public IsometricMoveScript playerScript;

    public GameObject endDialogue;

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera cam8;
    public Camera monsterCam;

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
        endDialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.playerIsCorner1) {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;

        }

        if (playerScript.playerIsCorner2) {
            cam2.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;

        }

        if (playerScript.playerIsCorner3) {
            cam3.enabled = true;
            cam2.enabled = false;
            cam1.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;

        }

        if (playerScript.playerIsCorner4) {
            cam4.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
        }

        if (playerScript.playerIsCorner5) {
            cam5.enabled = true;
            cam4.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;

        }

        if (playerScript.playerIsCorner6) {
            cam6.enabled = true;
            cam5.enabled = false;
            cam4.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;

        }

        if (playerScript.playerIsCorner7) {
            cam7.enabled = true;
            cam5.enabled = false;
            cam6.enabled = false;
            cam4.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;
            cam8.enabled = false;

        }

        if (playerScript.playerIsCorner8) {
            cam8.enabled = true;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam4.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;

        }

        if(playerScript.playerIsMonsterCam) {
            //switch to monster cam
            monsterCam.enabled = true;

            cam8.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam4.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;

            //set dialogue active
            endDialogue.SetActive(true);
        }


    }
}

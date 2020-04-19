using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPerspectiveSwitch : MonoBehaviour
{
    //track which corner the player is in
    public IsometricMoveScript playerScript;

    //cam to switch to diff perspectives & tag to mainCam
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;

    public Transform per1;
    public Transform per2;
    public Transform per3;
    public Transform per4;

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        //mainCamera is already set to perspective 1: perspective 1 -> perspective2
        // step 1: calculate vector from camera to target
        //camera
        Vector3 cameraPos = Camera.main.transform.position;
        //target
        Vector3 targetPos = Perspective2.position;
        Vector3 distanceFromCamToTarget = targetPos - cameraPos;

        // step 2: set camera to match that vector
        Camera.main.transform.forward = distanceFromCamToTarget;
        */


        //set the main.camera of player to the current cam

        

        if (playerScript.playerIsCorner1) {
            //cam1 is the main camera
            cam1.enabled = true;
            cam2.enabled = false; 
            cam3.enabled = false;
            cam4.enabled = false;

        }

        if (playerScript.playerIsCorner2) {
            //cam2 is the main camera
            cam2.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
        }

        if (playerScript.playerIsCorner3) {
            //cam3 is the main camera
            cam3.enabled = true;
            cam2.enabled = false;
            cam1.enabled = false;
            cam4.enabled = false;
        }

        if (playerScript.playerIsCorner4) {
            //cam4 is the main camera
            cam4.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam1.enabled = false;
        }
    }
}

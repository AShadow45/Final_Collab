using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is for first person rotation with mouse/trackpad

public class MouseRot : MonoBehaviour
{
    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;
    private float xRot = 0.0f;
    private float yRot = 0.0f;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRot += mouseX;
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);

        cam.transform.eulerAngles = new Vector3(xRot, yRot, 0.0f);
    }
}

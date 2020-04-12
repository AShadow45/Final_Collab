using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldMoveScript : MonoBehaviour
{
    /* 
     * Visual Notes
     * trail effects: https://www.youtube.com/watch?v=_TcEfIXpmRI
     * glowy: https://www.youtube.com/watch?v=WiDVoj5VQ4c
     */

    AudioSource audioS;
    public float startingPitch = 1f;
    private float pitchInc = 0f;

    private Vector3 mousePos;
    private Vector2 direction;
    private Rigidbody2D rb;

    public float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioS = GetComponent<AudioSource>();

        //Initialize the pitch
        audioS.pitch = startingPitch;
    }

    //if only one 2D player gameobject is being used, separate movement code into function and arrange by bool according to scene
    void Update()
    {
        //direction towards mouse
        LookAtMouse();

        //if mouse is being held down
        if (Input.GetMouseButton(0))
        {
            //object moves towards cursor
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePos - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        }else {
            //object doesn't move
            //code the object to drift
            rb.velocity = Vector2.zero;
        }

    }

    //might not be needed
    void LookAtMouse() {
        //get the vector between the mouse and the object
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        //calculate the angle and convert into degrees
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //rotation on the z-axis
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("chime")) {
            //play audio clip
            audioS.Play();
            Debug.Log("bang the chime");

            //each time the chime is hit, increase pitch

            //ISSUE: its not connected to the audio component or something cos the pitch isnt changing, 
            //starting pitch changes if u change it in the float, the increment doesn't
            pitchInc = pitchInc + 0.2f;
            startingPitch = startingPitch + pitchInc;
        }
    }
}

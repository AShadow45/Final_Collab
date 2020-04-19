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
    public AudioClip[] audioClips;

    private Vector3 mousePos;
    private Vector2 direction;
    private Rigidbody2D rb;

    public float moveSpeed;

    public bool gameIsPaused;

    public GameObject endDialogue;

    private void Awake()
    {
        Cursor.visible = true;
    }

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        audioS = GetComponent<AudioSource>();

        //toggling movement and lookat function on and off after dialogue array has been reached
        gameIsPaused = true;
    }

    //if only one 2D player gameobject is being used, separate movement code into function and arrange by bool according to scene
    void Update()
    {
        //if game is not paused (DialogueScript)
        if (!gameIsPaused)
        {
            //direction towards mouse
            LookAtMouse();

            //move function
            HoldMove();
        } else {
            gameIsPaused = true;
        }

    }

    void LookAtMouse() {

        //get the vector between the mouse and the object
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        //calculate the angle and convert into degrees
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //rotation on the z-axis
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void HoldMove() {
        //if mouse is being held down
        if (Input.GetMouseButton(0))
        {
            //object moves towards cursor
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePos - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        }
        else
        {
            //object doesn't move
            //code the object to drift
            rb.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("chime")) {
            //play random audio clip
            PlayRandom();
            Debug.Log("bang the chime");

        }
    }

    void PlayRandom()
    {
        audioS.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioS.Play();
    }
}

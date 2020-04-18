using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindScript : MonoBehaviour
{
    public StartDahli startD;
    public CrouchingScript playerScript;

    public Transform spawnPoint;
    public Transform spawnPoint2;

    private Animator anim;

    Rigidbody2D rb;
    public AreaEffector2D ae2D;
    public float moveAmount = 3f;

    public bool windIsStart;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ae2D = GetComponent<AreaEffector2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //wind starts when windIsStart is true
        if (windIsStart)
        {
            Wind();
        }

        if (playerScript.windIsFade) {

            transform.position = spawnPoint2.transform.position;
        }

    }

    //wind moving function and respawning function
    void Wind() {
        rb.velocity = -transform.right * moveAmount;
        if (transform.position.x < -10f)
        {
            transform.position = spawnPoint.transform.position;
        }
    }
}

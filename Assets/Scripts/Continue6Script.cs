using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue6Script : MonoBehaviour
{
    public EndEscher endE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            endE.NextSentence();

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue4Script : MonoBehaviour
{
    public EndDahliScript endD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            endD.NextSentence();

        }
    }
}

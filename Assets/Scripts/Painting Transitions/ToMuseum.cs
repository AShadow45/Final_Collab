<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMuseum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player"){
           SceneManager.LoadScene("Museum");
       } 
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMuseum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player"){
           SceneManager.LoadScene("Museum");
       } 
    }
}
>>>>>>> 2df62836420f000a83fb5e4e4797387ef1d686f8

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscherEffectsScript : MonoBehaviour
{
    public static EscherEffectsScript instance = null;

    //holds the gameobject of effects

    void Awake()
    {
        // If we don't have an instance set - set it now
        if (!instance)
            instance = this;
        // Otherwise, its a double, we dont need it - destroy
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
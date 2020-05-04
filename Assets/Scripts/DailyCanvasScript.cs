using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCanvasScript : MonoBehaviour
{
    public static DailyCanvasScript instance = null;

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
}

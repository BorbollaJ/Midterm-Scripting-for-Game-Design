using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimishing_Light : MonoBehaviour
{
    public Light lamp;

    private float diminishLight = 1;
    private double timePassed = 100;

    // Update is called once per frame
    void Update()
    {
        if (timePassed >= 0)
        {
            diminishLight -= 0.0005f;
            timePassed -= Time.deltaTime + 0.005; 
        }
        else if (timePassed < 0)
        {
            Application.Quit();
        }

        lamp.intensity = diminishLight;
    }
}

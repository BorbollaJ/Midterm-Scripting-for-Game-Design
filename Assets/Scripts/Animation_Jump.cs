using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animation_Jump : MonoBehaviour
{
   public Animation jumpUp;
    public GameObject noteNPC;

    private void Update()
    {
        if (Input.GetKeyDown("Jump"))
        {
            jumpUp.Play();
        }
    }
}

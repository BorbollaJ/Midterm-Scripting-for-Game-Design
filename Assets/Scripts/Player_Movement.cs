using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float turningSpeed;


    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        Vector3 tempR = this.transform.localEulerAngles;
        tempR.y += turningSpeed * Time.deltaTime * horizontal;

        controller.Move(this.transform.forward * speed * forward * Time.deltaTime);

        this.transform.localEulerAngles = tempR;
    }
}

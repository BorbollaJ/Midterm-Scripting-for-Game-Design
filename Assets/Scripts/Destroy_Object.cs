using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Object : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

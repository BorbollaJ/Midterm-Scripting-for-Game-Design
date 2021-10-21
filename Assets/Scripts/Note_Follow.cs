using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Note_Follow : MonoBehaviour
{
    public GameObject playerNote;
    public GameObject NPCNote;
    public NavMeshAgent followPlayer;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerLocation = playerNote.transform.localPosition;

        followPlayer.destination = playerLocation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportating : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject thePlayer;

    void OntriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
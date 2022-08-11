using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progressRace : MonoBehaviour
{

    public Transform[] checkpoints;
    public GameObject lapCounter;
    public int lap;
    public int crntCheckpoint;
    public float dist;
    public float totalComp;
    public int position;
    // Use this for initialization
    void Start()
    {

        lap = 0;
        crntCheckpoint = 0;

    }

    // Update is called once per frame
    void LateUpdate()
    {

        dist = Vector3.Distance(transform.position, checkpoints[crntCheckpoint].position);
        int laps = lap * 1000;
        int checks = crntCheckpoint * 100;
        totalComp = laps + checks + dist;

    }

    void OnTriggerEnter(Collider enter3D)
    {

        if (enter3D.gameObject.tag == "LAP")
        {
            lap += 1;
        }


        if (enter3D.gameObject.tag == "CHECKPOINT")
        {

            if (crntCheckpoint < checkpoints.Length - 1 && lap > 0)
            {
                crntCheckpoint += 1;
            }
            else { crntCheckpoint = 0; }



        }
    }
}
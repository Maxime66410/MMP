using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTimer : MonoBehaviour
{

    float lapTimer = 0f;
    bool lapComplete;
    public GameObject laptiMer;

    void Update()
    {
        lapTimer += Time.deltaTime;
        if (lapComplete)
        {
            DisplayLapTime(lapTimer);
            lapTimer = 0f;
        }
    }

    void DisplayLapTime(float _time)
    {
       
    }
}
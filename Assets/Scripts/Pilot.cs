using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    // Public variables
    public string pilotName;
    public float experienceLevel;

    // Public methods
    public float GetFlightSkill()
    {
        return experienceLevel * 10.0f;
    }

    public void PromotePilot(float increment)
    {
        experienceLevel += increment;
        Debug.Log(pilotName + " promoted to experience level: " + experienceLevel);
    }
}

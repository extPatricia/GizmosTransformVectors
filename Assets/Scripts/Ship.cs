using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Public variables
    public string shipName;
    public Pilot shipPilot;
    public Planet currentPlanet;

    // Private variables
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ship " + shipName + " initialized with speed " + _speed);
        if (shipPilot != null)
        {
            Debug.Log("Pilot: " + shipPilot.pilotName + " with flight skill: " + shipPilot.GetFlightSkill());
        }

        if (currentPlanet != null)
        {
            Debug.Log("Current Planet: " + currentPlanet.planetName + " with gravity: " + currentPlanet.GetGravity());
            Debug.Log("Final Speed on " + currentPlanet.planetName + ": " + GetFinalSpeed(currentPlanet));
        }

    }

    // Public methods
    public float GetFinalSpeed(Planet planet)
    {
        return _speed * (1 + shipPilot.GetFlightSkill() - planet.GetGravity() * 0.2f);
    } 
    
}

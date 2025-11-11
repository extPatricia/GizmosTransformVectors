using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    // Public variables
    public string planetName;

    // Private variables
    [SerializeField] private float _gravity;
    [SerializeField] private float _friction;

    // Public methods
    public float GetGravity()
    {
        return _gravity;
    }

    public float GetFriction()
    {
        return _friction;
    }


}

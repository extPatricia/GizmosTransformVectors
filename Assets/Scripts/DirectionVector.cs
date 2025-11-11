using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    // Public variables
    public Transform finalTransform;
    public Transform startTransform;
    public float speed = 1;

    // Private variables
    private Vector3 _directionVector;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate direction vector
        _directionVector = finalTransform.position - startTransform.position;

        // Make it a unit vector
        _directionVector.Normalize();

        // Draw the direction vector
        Debug.DrawRay(startTransform.position, _directionVector * speed, Color.red);

        // Move the start transform along the direction vector
        startTransform.Translate(_directionVector * speed * Time.deltaTime);

        // Print magnitude of the direction vector
        print("Magnitude: " + _directionVector.magnitude * speed);

        // Calculate distance between start and final transforms
        float distance = Vector3.Distance(startTransform.position, finalTransform.position);
        print("Distance:" + distance);

        if (distance < 10 || distance > 20)
            speed *= -1;

    }
}

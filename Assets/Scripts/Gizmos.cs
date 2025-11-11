using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmos : MonoBehaviour
{
    // Public variables
    public Vector2 point1;
    public Vector2 point2;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(point1, point2, Color.red);

        // Draw a cross at the origin
        //Debug.DrawLine(new Vector2(0,0), new Vector2(2,2), Color.red);
        //Debug.DrawLine(new Vector2(2,0), new Vector2(0,2), Color.red);

        // Draw Ray
        // Local Axis of the GameObject
        Debug.DrawRay(transform.position, transform.up, Color.green);
        Debug.DrawRay(transform.position, transform.right, Color.black);
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
    }
}

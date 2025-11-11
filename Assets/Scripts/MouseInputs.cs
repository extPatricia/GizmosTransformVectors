using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    // Public variables
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
            print("Left mouse button was released.");
        if(Input.GetMouseButtonUp(1))
            print("Right mouse button was pressed.");
        if(Input.GetMouseButtonUp(2))
            print("Middle mouse button was released.");

        // Mouse position
        print("Mouse position x: " + Input.mousePosition.x + ", y: " + Input.mousePosition.y);

        target.position = Input.mousePosition;
    }
}

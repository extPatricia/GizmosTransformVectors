using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Public variables
    public Transform cubeTransform;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mouse Axis Debug
        //Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal") * 5, Color.red);
        //Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical") * 5, Color.blue);

        // Keyboard Axis debug
        Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Mouse X") * 5, Color.blue);
        Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Mouse Y") * 5, Color.blue);
        
        // Button
        if (Input.GetButtonUp("Fire1"))
            print("Fire1!!");

        // Mouse Wheel
        print("Mouse ScrollWheel: " + Input.GetAxis("Mouse ScrollWheel"));

        // Movement by mouse
        //cubeTransform.Translate(Vector3.right * Input.GetAxis("Mouse X") * speed * Time.deltaTime);
        //cubeTransform.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * speed * Time.deltaTime);

        // Movement by keyboard
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}

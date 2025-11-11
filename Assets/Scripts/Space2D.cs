using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space2D : MonoBehaviour
{
    // Public variables
    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedX;
    public float speedY;
    public float speedRotation;

    // Private variables
    private float _rotationAngle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Movement in two edges
        // playerTransform.Translate(0,0,0);

        playerTransform.Translate(Vector3.right * Time.deltaTime * speedX); //Time.deltaTime = 1 / 300 
        playerTransform.Translate(Vector3.left * Time.deltaTime * speedY);

        // Rotation in one edge
        playerTransform.Rotate(speedRotation * Time.deltaTime, 0, 0);

        // Rotate Around Sphere 
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, _rotationAngle * Time.deltaTime * speedRotation);
        _rotationAngle++;

    }
}

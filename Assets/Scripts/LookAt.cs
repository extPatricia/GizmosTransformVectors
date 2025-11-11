using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
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
        //transform.LookAt(target); // mirando hacia el objetivo
        transform.LookAt(target.position); // mirando hacia la posicion del objetivo
        //transform.LookAt(new Vector3(5,5,5)); // mirando hacia una posicion fija

        print("Target x: " + target.position.x + " / Target y: " + target.position.y + " / Target z: " + target.position.z);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Public variables
    public float scaleX;
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale.x = 1;
        transform.position = new Vector3(5, transform.position.y, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            print("Return key was pressed.");
        if (Input.GetKey(KeyCode.Return))
            print("Return key is pressing.");
        if (Input.GetKeyUp(KeyCode.Return))
            print("Return key is down.");
    }
}

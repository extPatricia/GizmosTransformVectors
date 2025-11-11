using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // P
        Debug.DrawLine(new Vector2(0, 0), new Vector2(0, 2), Color.blue);
        Debug.DrawLine(new Vector2(0, 2), new Vector2(2, 2), Color.blue);
        Debug.DrawLine(new Vector2(2, 2), new Vector2(2, 1), Color.blue);
        Debug.DrawLine(new Vector2(2, 1), new Vector2(0, 1), Color.blue);
        Debug.DrawLine(new Vector2(0, 1), new Vector2(0, 0), Color.blue);

        // A
        Debug.DrawLine(new Vector2(0, 0), new Vector2(2, 0), Color.blue);
        Debug.DrawLine(new Vector2(2, 0), new Vector2(2.5f, 1), Color.blue);
        Debug.DrawLine(new Vector2(2.5f, 1), new Vector2(3.5f, 1), Color.blue);
        Debug.DrawLine(new Vector2(3.5f, 1), new Vector2(2.5f, 1), Color.blue);
        Debug.DrawLine(new Vector2(2.5f, 1), new Vector2(3, 2), Color.blue);
        Debug.DrawLine(new Vector2(3, 2), new Vector2(4, 0), Color.blue);

        // T
        Debug.DrawLine(new Vector2(4, 0), new Vector2(5, 0), Color.blue);
        Debug.DrawLine(new Vector2(5, 0), new Vector2(5, 2), Color.blue);
        Debug.DrawLine(new Vector2(5, 2), new Vector2(4, 2), Color.blue);
        Debug.DrawLine(new Vector2(4, 2), new Vector2(6, 2), Color.blue);
        Debug.DrawLine(new Vector2(6, 2), new Vector2(5, 2), Color.blue);
        Debug.DrawLine(new Vector2(5, 2), new Vector2(5, 0), Color.blue);

        // R
        Debug.DrawLine(new Vector2(5, 0), new Vector2(7, 0), Color.blue);
        Debug.DrawLine(new Vector2(7, 0), new Vector2(7, 2), Color.blue);
        Debug.DrawLine(new Vector2(7, 2), new Vector2(9, 2), Color.blue);
        Debug.DrawLine(new Vector2(9, 2), new Vector2(9, 1), Color.blue);
        Debug.DrawLine(new Vector2(9, 1), new Vector2(7, 1), Color.blue);
        Debug.DrawLine(new Vector2(7, 1), new Vector2(9, 0), Color.blue);

        // I
        Debug.DrawLine(new Vector2(7, 1), new Vector2(9, 0), Color.blue);
        Debug.DrawLine(new Vector2(9, 0), new Vector2(10, 0), Color.blue);
        Debug.DrawLine(new Vector2(10, 0), new Vector2(10, 2), Color.blue);

    }
}

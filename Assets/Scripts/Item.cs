using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Public variables
    public string itemName;
    public int price;

    //Private variables
    private int _count;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Public methods
    public void UseItem()
    {
        Debug.Log("Using item: " + itemName);
    }
}

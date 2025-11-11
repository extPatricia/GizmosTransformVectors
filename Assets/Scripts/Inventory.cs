using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Public variables
    public Item[] items;
    //Private variables
    private int _itemCount;

    // Start is called before the first frame update
    void Start()
    {
        print("Inventory initialized with " + items.Length + " items.");
        
        for (int i = 0; i < items.Length; i++)
        {
            print("Item " + (i + 1) + ": " + items[i].itemName + " - Price: " + items[i].price);
            items[i].UseItem();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

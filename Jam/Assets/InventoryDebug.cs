using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDebug : MonoBehaviour
{
    public Item DebugThing;
    // Start is called before the first frame update
    void Start()
    {
        DebugThing = new Item();
        DebugThing.Name = "test";

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            gameObject.GetComponent<Inventory>().AddToBag(DebugThing);
        }
    }
}

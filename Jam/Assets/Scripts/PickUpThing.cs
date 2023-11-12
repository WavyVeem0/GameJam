using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpThing : MonoBehaviour
{   
    public string name = "";
    public Item item = new Item();
    void Start()
    {
        item.Name = name;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        other.gameObject.GetComponent<Inventory>().AddToBag(item);
        Destroy(gameObject);
    }
}

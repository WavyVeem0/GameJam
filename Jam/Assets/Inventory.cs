using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> bag;
    public static Inventory instance = null;
    void Start() 
    {
        if (instance == null) instance = this;
        else if(instance == this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        InitializeManager();
    }
    private void InitializeManager()
    {
        bag = new List<Item>() {};

    }
    public void AddToBag(Item thing)
    {
        if (bag.Count < 10)
        {
            thing.isInBag = true;

            bag.Add(thing);

            Debug.Log(thing.Name + " has been added!");
        }
        else 
        {
            Debug.Log("Not enought slots!");
        }

    }

    
}

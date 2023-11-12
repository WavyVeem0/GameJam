using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> bag;
    public UnityAction onTakeItemAction;
    public static Inventory instance = null;

    private void Start() 
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
    private void Update() 
    {
        Debug.Log(bag[0]);
    }

    public void AddToBag(Item thing)
    {
        if (bag.Count < 10)
        {
            thing.isInBag = true;
            onTakeItemAction.Invoke();
            bag.Add(thing);
            Debug.Log(thing.Name + " has been added!");
        }
        else 
        {
            Debug.Log("Not enought slots!");
        }

    }

    
}

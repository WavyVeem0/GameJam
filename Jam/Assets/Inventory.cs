using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> bag;
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

    }
    public void AddToBag(Item thing)
    {
        this.bag.Add(thing);
    }

    
}

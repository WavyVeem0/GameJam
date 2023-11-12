using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public List<Item> bag;
    public GameObject perunImg;
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

    public void AddToBag(Item thing)
    {
        if (bag.Count < 10)
        {
            thing.isInBag = true;
            onTakeItemAction?.Invoke();
            bag.Add(thing);
            perunImg.transform.localScale = new Vector3(0.666f,0.666f,0.666f);
        }
        else 
        {
            Debug.Log("Not enought slots!");
        }

    }

    
}

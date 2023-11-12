using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingItemsControl : MonoBehaviour
{
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            if(gameObject.GetComponent<Inventory>().bag[0] != null) 
            {
                Debug.Log("GOIDA");
            }
        }
    }
}

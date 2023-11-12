using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_Prefab : MonoBehaviour
{
    void Start()
    {
        if(StaticHolder.LastLocation == 3)
        {
            gameObject.transform.position = new Vector3(5, -19, 0);
        }  
        if(StaticHolder.LastLocation == 2)
        {
            gameObject.transform.position = new Vector3(52,-18,0);
        }
        if (StaticHolder.LastLocation == 4)
        {
            gameObject.transform.position = new Vector3(8, 25, 0);
        }
    }
}

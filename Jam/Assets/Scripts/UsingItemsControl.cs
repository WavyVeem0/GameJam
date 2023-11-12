using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingItemsControl : MonoBehaviour
{
    public float Cooldown;
    public float maxCooldown;
    public bool isActive;
    public float speedDuration;
    
    void Start() 
    {
        Cooldown = maxCooldown;
        isActive = false;
    }
    void Update()
    {
        Cooldown -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            if(gameObject.GetComponent<Inventory>().bag[0] != null && Cooldown <= 0) 
            {
                gameObject.GetComponent<Move>().speed *= 4;
                isActive = true;
                Cooldown = maxCooldown;
            }
        }
        if (Cooldown + speedDuration <= maxCooldown && isActive)
        {
            gameObject.GetComponent<Move>().speed /= 4;
            isActive = false;
        }
    }
}

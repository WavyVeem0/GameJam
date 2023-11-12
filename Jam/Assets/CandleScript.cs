using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScript : MonoBehaviour
{
    public static int counter = 0;
    private bool isActive = true;
    public Sprite ActiveCandle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E) && isActive)
            {
                counter++;
                isActive = !isActive;
                gameObject.GetComponent<SpriteRenderer>().sprite = ActiveCandle;
            }
        }
    }
}

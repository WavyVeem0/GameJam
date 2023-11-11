using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform placeToTeleport;
    [SerializeField] private GameObject pressTextObj;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                collision.gameObject.transform.position = placeToTeleport.position;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") pressTextObj.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") pressTextObj.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP_KV_UL : MonoBehaviour
{
    [SerializeField] private GameObject pressTextObj;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(2);
                Destroy(collision.gameObject);
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

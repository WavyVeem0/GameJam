using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class TP_2_PD1 : MonoBehaviour
{
    [SerializeField] private GameObject pressTextObj;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(aaa());
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Player") pressTextObj.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.tag == "Player") pressTextObj.SetActive(false);
    }
    IEnumerator aaa() {
        yield return  new WaitForSeconds(6);
                SceneManager.LoadScene(6);
                SoundsController.Instance.PlaySound(SoundsController.AudioClips.OpenDoorSound);
                Destroy(Inventory.instance.gameObject);
    }
}

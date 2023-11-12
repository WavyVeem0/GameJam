using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogueFlat : MonoBehaviour
{
    [SerializeField] private GameObject pressTextObj;
    public int idDialogue;
    bool needClick;
    private void Start()
    {
        if (!needClick) Flat.Instance.CheckDialogues();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Flat.Instance.StartDialogue(idDialogue);
                pressTextObj.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !Flat.Instance.usedDialogues[idDialogue]) pressTextObj.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !Flat.Instance.usedDialogues[idDialogue]) pressTextObj.SetActive(false);
    }
}

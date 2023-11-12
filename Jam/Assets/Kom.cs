using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kom : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                anim.SetBool("Open", true);
            }
        }
    }
    IEnumerator Check()
    {
        for(; ; )
        {
            if (Flat.Instance.usedDialogues[4])
            yield return new WaitForSeconds(0.3f);
        }
    }
}

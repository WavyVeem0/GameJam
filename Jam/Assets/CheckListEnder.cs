using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckListEnder : MonoBehaviour
{
    [SerializeField] private GameObject canvasObj, dialogueSinner, dialogueNotSinner;
    public void StartCheck()
    {
        bool sinner = true;
        for(int i = 0; i < CheckList.Instance.completedQuests.Length; i++)
        {
            if (!CheckList.Instance.completedQuests[i]) sinner = false;
        }
        switch (sinner)
        {
            case true:
                var ins = Instantiate(dialogueSinner, canvasObj.transform);
                ins.GetComponent<Dialogue>().ActionOnAnswer += SinnerPunishment;
                break;

            case false:
                var ins2 = Instantiate(dialogueNotSinner, canvasObj.transform);
                break;
        }
    }
    private void SinnerPunishment() // Boss fight?
    {

    }
    private void SinnerForgive() // Restart game
    {
        StartCoroutine(ClearCheckList());
    }
    IEnumerator ClearCheckList()
    {
        CheckList.Instance.gameObject.AddComponent<Shake>();
        for (int i = 0; i < CheckList.Instance.completedQuests.Length; i++)
        {
            CheckList.Instance.completedQuests[i] = false;
            CheckList.Instance.RefreshQuests();
            yield return new WaitForSeconds(0.3f);
        }
        yield return null;
    }
}

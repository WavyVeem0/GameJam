using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public int id;
    public float completeState;

    public void CheckQuest()
    {
        if(completeState >= 1)
        {
            CheckList.Instance.completedQuests[id] = true;
            CheckList.Instance.RefreshQuests();
        }
    }
    public void ChangeCompleteState(float value)
    {
        completeState = value;
        CheckQuest(); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstQuest : Quest
{
    private void Awake()
    {
        Inventory.instance.onTakeItemAction += EndQuest;
    }
    
    private void EndQuest()
    {
        completeState += 1;
        CheckQuest();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstQuest : Quest
{
    private void Start()
    {
        Inventory.instance.onTakeItemAction += EndQuest;
    }
    
    private void EndQuest()
    {
        completeState += 1;
        CheckQuest();
    }
}

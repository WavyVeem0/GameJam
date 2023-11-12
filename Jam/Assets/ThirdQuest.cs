using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdQuest : Quest
{
    [SerializeField] private GameObject QTEobj, pressTextObj;
    private int stage;
    private bool started;
    public void StartQuest(float speed, int maxButtonsCount)
    {
        var instance = Instantiate(QTEobj);
        QuickTimeEvent qteInstance = instance.GetComponentInChildren<QuickTimeEvent>();
        qteInstance.buttonsCount = UnityEngine.Random.Range(3, maxButtonsCount);
        qteInstance.timeToClick = speed;
        qteInstance.ActionOnWin += NextStage;
    }
    public void NextStage()
    {
        stage++;
        completeState += 0.35f;
        CheckQuest();
        if (stage >= 4) return;
        StartQuest(2 / stage, stage * 5);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if(!started)
                {
                    NextStage();
                    started = true;
                }
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

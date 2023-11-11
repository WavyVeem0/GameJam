using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckList : MonoBehaviour
{

    public bool[] completedQuests = new bool[10];
    [SerializeField] private GameObject[] crosses;
    
    static public CheckList Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    public void RefreshQuests()
    {
        for(int i = 0; i < crosses.Length; i++)
        {
            if (completedQuests[i])
            {
                crosses[i].SetActive(true);
            } 
        }
    }
}

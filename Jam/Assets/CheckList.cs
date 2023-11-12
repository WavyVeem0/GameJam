using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckList : MonoBehaviour
{

    public bool[] completedQuests = new bool[10];
    [SerializeField] private GameObject[] crosses;
    [SerializeField] private GameObject cn, endObj;
    
    static public CheckList Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(cn);
    }
    public void RefreshQuests()
    {
        for(int i = 0; i < crosses.Length; i++) 
        {
            if (completedQuests[i])
            {
                crosses[i].SetActive(true);
                if(i == 2)
                {
                    Instantiate(endObj);
                }
            } 
        }
    }
}

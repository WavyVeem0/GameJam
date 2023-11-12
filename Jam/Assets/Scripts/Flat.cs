using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flat : MonoBehaviour
{
    public GameObject[] allDialogues;
    public bool[] usedDialogues;
    static public Flat Instance {  get; private set; }
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        usedDialogues = new bool[allDialogues.Length];
        for(int  i = 0; i < allDialogues.Length; i++)
        {
            //if (PlayerPrefs.GetInt(i.ToString() + "D", 0) == 1)
                //usedDialogues[i] = true;
        }
    }
    private void Start()
    {
        CheckDialogues();
    }
    public void CheckDialogues()
    {
        if (SceneManager.GetActiveScene().name == "Kvartira" && !usedDialogues[0]) StartDialogue(0);
        if (SceneManager.GetActiveScene().name == "Uliza" && !usedDialogues[2] && usedDialogues[1]) StartDialogue(2);
    }
    public void StartDialogue(int id)
    {
        if(!usedDialogues[id])
        {
            Instantiate(allDialogues[id]);
            usedDialogues[id] = true;
            PlayerPrefs.SetInt(id.ToString() + "D", 1);

        }
    }
}

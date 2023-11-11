using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject LoadScreenObj;
    public void StartGame(int difficulty)
    {
        var instance = Instantiate(LoadScreenObj, transform);
        instance.GetComponent<LoadingScreen>().StartLoad(1);
    }
    public void ExitGame()
    {
        print("ЗДЕСЬ НЕТ ВЫХОДА 🤬");
        // Application.Quit();
    }
}

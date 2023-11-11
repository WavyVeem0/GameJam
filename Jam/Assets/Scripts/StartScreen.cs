using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame(int difficulty)
    {
        print("ИГРА НАЧИНАЕТСЯ 😡");
    }
    public void ExitGame()
    {
        print("ЗДЕСЬ НЕТ ВЫХОДА 🤬");
        // Application.Quit();
    }
}

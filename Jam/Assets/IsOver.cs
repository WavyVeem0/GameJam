using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsOver : MonoBehaviour
{
    public static bool isOver = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && isOver)
        {
            SceneManager.LoadScene(1);
            isOver = false;
        }
    }
}

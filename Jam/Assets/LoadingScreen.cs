using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private Image LoadingCircleIMG;
    public void StartLoad(int scene)
    {
        StartCoroutine(AsyncLoad(scene));
    }
    IEnumerator AsyncLoad(int scene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(scene);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            LoadingCircleIMG.fillAmount = progress;
            yield return null;
        }
    }
}

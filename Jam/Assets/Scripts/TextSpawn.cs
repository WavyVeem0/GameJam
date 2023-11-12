using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TextSpawn : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Dialogue dS;
    private TextMeshProUGUI textOnObject;
    private string currentText;
    private float speed = 0.03f;
    private bool isSpawning;
    private void Awake()
    {
        textOnObject = GetComponent<TextMeshProUGUI>();
    }
    public void StartSpawnText(string text)
    {
        currentText = text;
        textOnObject.text = "";
        isSpawning = true;
        StartCoroutine(TextT(currentText));
    }
    private IEnumerator TextT(string text)
    {
        for(int i = 0; i < text.Length; i++)
        {
            textOnObject.text += text[i];
            yield return new WaitForSeconds(speed);
        }
        dS.ActivateAnswers(false);
        speed = 0.03f;
        isSpawning = false;
        yield return null;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isSpawning) speed = 0.001f;
        else dS.ActivateAnswers(true);
    }
    public void Da()
    {
        if (isSpawning) speed = 0.001f;
        else dS.ActivateAnswers(true);
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    public Speaker[] allInformations;
    public UnityAction ActionOnAnswer;
    [SerializeField] private Image speakerImage;
    [SerializeField] private TextSpawn textSpawner;
    [SerializeField] private TextMeshProUGUI[] answerButtonsTextes;
    [SerializeField] private GameObject[] answerButtonsObj;
    private int currentSpeech;
    private void Start()
    {
        NextSpeech();
    }
    private void NextSpeech()
    {
        textSpawner.StartSpawnText(allInformations[currentSpeech].speech);
        speakerImage.sprite = allInformations[currentSpeech].img;
    }
    public void ActivateAnswers(bool click)
    {
        if (allInformations[currentSpeech].needAnswer)
        {
            RefreshAnswers();
        }
        else if (!allInformations[currentSpeech].needAnswer && click) Answer(1000);
    }
    public void Answer(int answer)
    {
        switch(answer)
        {
            case 0: //First answer
                if(currentSpeech < allInformations.Length - 1)
                {
                    currentSpeech++;
                    NextSpeech();
                }
                else
                {
                    ActionOnAnswer.Invoke();
                    Destroy(gameObject);
                }
                break;
            case 1: //SecondAnswer
                if (currentSpeech < allInformations.Length - 1)
                {
                    ActionOnAnswer.Invoke();
                    currentSpeech++;
                    NextSpeech();
                }
                else
                {
                    Destroy(gameObject);
                }
                break;
            default:
                if (currentSpeech < allInformations.Length - 1)
                {
                    currentSpeech++;
                    NextSpeech();
                }
                else
                {
                    Destroy(gameObject);
                }
                break;
        }
    }
    private void RefreshAnswers()
    {
        for (int i = 0; i < answerButtonsTextes.Length; i++)
        {
            answerButtonsTextes[i].text = allInformations[currentSpeech].answers[i];
            answerButtonsObj[i].SetActive(true);
        }
    }
}
[Serializable]
public class Speaker
{
    public string speech;
    public Sprite img;
    public bool needAnswer;
    public string[] answers = new string[2];
}

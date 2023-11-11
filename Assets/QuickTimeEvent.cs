using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEvent : MonoBehaviour
{
    public float timeToClick = 1;
    public int buttonsCount = 3;
    [SerializeField] private Animator[] buttonsAnimators;
    private int pressedButtons;
    private int currentPressedButton = -1;
    private int activeButton;
    private bool failure;
    private void Start()
    {
        StartCoroutine(QTE());
    }
    private void Update()
    {
        currentPressedButton = -1;
        if (Input.GetKeyDown(KeyCode.W)) currentPressedButton = 0;
        else if (Input.GetKeyDown(KeyCode.D)) currentPressedButton = 1;
        else if (Input.GetKeyDown(KeyCode.S)) currentPressedButton = 2;
        else if (Input.GetKeyDown(KeyCode.A)) currentPressedButton = 3;
        
        if(currentPressedButton == activeButton && !failure)
        {
            pressedButtons++;
            StopAllCoroutines();
            if (pressedButtons < buttonsCount)
            {
                RefreshButtons();
                StartCoroutine(QTE());
            }
            else
            {
                print("ПОДЕБА"); // Если игрок смог справиться с QTE, то что-то должно произойти
                Destroy(gameObject);
            }

        }
        else if (currentPressedButton != activeButton && currentPressedButton != -1) failure = true;

        if(failure)
        {
            print("НЕПОДЕБА"); // Что-то происходит из-за того, что игрок не справился с QTE
            Destroy(gameObject);
        }
    }
    private IEnumerator QTE()
    {
        yield return new WaitForSeconds(0.1f);
        activeButton = Random.Range(0, 4);
        buttonsAnimators[activeButton].speed = 1 / timeToClick;
        buttonsAnimators[activeButton].SetBool("Active", true);
        yield return new WaitForSeconds(timeToClick + 0.15f);
        failure = true;
        yield return null;

    }
    private void RefreshButtons()
    {
        for(int i = 0; i < buttonsAnimators.Length; i++) buttonsAnimators[i].SetBool("Active", false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompletecurrentQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextcurrentQuestion;
    public bool isAnsweringcurrentQuestion = false;
    public float fillFraction;

    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringcurrentQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompletecurrentQuestion;
            }
            else
            {
                isAnsweringcurrentQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringcurrentQuestion = true;
                timerValue = timeToCompletecurrentQuestion;
                loadNextcurrentQuestion = true;
            }
        }

        Debug.Log(timerValue);
    }
}

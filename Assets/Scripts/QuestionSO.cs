using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,5)]
    [SerializeField] string currentQuestion = "Enter new currentQuestion";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string getcurrentQuestion()
    {
        return currentQuestion;
    }

    public int getCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string getAnswer(int index)
    {
        return answers[index];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    public bool isCorrectAns = false;
    public QuizManager qm;

    public void Answer()
    {
        if (isCorrectAns)
        {
            qm.CorrectAns();
        }
        else
        {
            qm.WrongAns();
        }
    }
}

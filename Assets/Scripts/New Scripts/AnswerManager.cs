using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

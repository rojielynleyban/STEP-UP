using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueToQuiz : MonoBehaviour
{
    public GameObject QuizPanel, Level2, Level3, Level4, Level5;

    public void ContinueButton()
    {
        Level2 = GameObject.Find("Level2"); Level2.SetActive(false);
        Level3 = GameObject.Find("Level3"); Level3.SetActive(false);
        Level4 = GameObject.Find("Level4"); Level4.SetActive(false);
        Level5 = GameObject.Find("Level5"); Level5.SetActive(false);

        QuizPanel.SetActive(true);
    }
}

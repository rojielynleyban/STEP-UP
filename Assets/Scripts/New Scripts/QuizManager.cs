using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QueAndAnsManager> queAndAns;
    public GameObject[] choices;
    public int currentQues;

    public Text QuestionText;
    public Text ScoreText;
    public Text NumTitle;

    [SerializeField]
    private string NextScene;

    public GameObject QuizPanel;

    int totalQues = 0;
    public int quesnum = 0;
    public int score;

    private void Start()
    {
        totalQues = queAndAns.Count;
        NumTitle.text = "LEVEL " + quesnum;
        GenerateQues();
    }

    void LevelComplete()
    {
        //new switch to next scene
        SceneManager.LoadScene(sceneName: NextScene);

        // old code
        // QuizPanel.SetActive(false);
        // BgPanel.SetActive(true);
        // ScoreText.text = score + "/" + totalQues;
    }

    public void CorrectAns()
    {
        score += 1;
        queAndAns.RemoveAt(currentQues);
        GenerateQues();
    }

    public void WrongAns()
    {
        queAndAns.RemoveAt(currentQues);
        GenerateQues();
    }

    void GenerateQues()
    {
        if (queAndAns.Count > 0)
        {
            quesnum += 1;
            NumTitle.text = "LEVEL " + quesnum;

            currentQues = Random.Range(0, queAndAns.Count);
            ScoreText.text = score.ToString();
            QuestionText.text = queAndAns[currentQues].Question;
            SetAnswer();
        }
        else
        {
            ScoreText.text = score.ToString();
            LevelComplete();
        }
    }

    void SetAnswer()
    {
        for (int i = 0; i < choices.Length; i++)
        {
            choices[i].GetComponent<AnswerManager>().isCorrectAns = false;
            choices[i].transform.GetChild(0).GetComponent<Text>().text = queAndAns[currentQues].Answers[i];

            if (queAndAns[currentQues].correctAns == (i + 1))
            {
                choices[i].GetComponent<AnswerManager>().isCorrectAns = true;
            }
        }
    }
}


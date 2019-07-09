
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;

    void Update()
    {
        scoreText.text = "Score:" + score.ToString();
        if(score >= 10000)
        {
            SceneManager.LoadScene("Boss");
        }
    }

    public void AddPoint(int point)
    {
        score = score + point;
    }
}

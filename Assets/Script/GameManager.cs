using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text highScore;



    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
       // HighScorerAdd();
    }


    public void ResetScore()
    {
        score = 0;
        


    }
    public void HighScorerAdd()
    {
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
        }
        highScore.text = "High Score:" + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void AddScore()
    {
        score++;
        HighScorerAdd();
        scoreText.text = score.ToString();

    }
}
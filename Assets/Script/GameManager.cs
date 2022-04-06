using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text highScore;



    void Start()
    {
        HighScorerAdd();
    }
    void Update()
    {
    }


    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    public void HighScorerAdd()
    {
        int number = score;
        scoreText.text=number.ToString();
       if (number > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            
        }
        highScore.text = "High Score:" + number.ToString();
    }
    public void AddScore()
    {
        score++;
        HighScorerAdd();
        scoreText.text = score.ToString();
        
    }
}

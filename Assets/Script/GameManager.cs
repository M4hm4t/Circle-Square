using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;



    void Start()
    {
        
    }
    void Update()
    {
    }
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        
    }
}

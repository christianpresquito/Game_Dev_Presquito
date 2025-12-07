using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    public Text scoreText; // your existing score text
    public Text highScoreText; // a new text for high score display (optional)

    private int highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); // load saved high score
        UpdateHighScoreText();
    }

    void Update()
    {
        // Try parsing your current score text
        int currentScore = 0;
        int.TryParse(scoreText.text, out currentScore);

        // Update high score if current score is higher
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore); // save it
            UpdateHighScoreText();
        }
    }

    void UpdateHighScoreText()
    {
        if (highScoreText != null)
            highScoreText.text = "High Score: " + highScore;
    }
}

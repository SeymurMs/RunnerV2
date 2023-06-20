using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScoreScript : MonoBehaviour
{
    [SerializeField] private ScoreController score;
    [SerializeField] private PlayerController GameOverField;
    [SerializeField] private Text MaxScoreText;
    private float MaxScore;
    private void Update()
    {
        CheckMaxScore();
    }
    void CheckMaxScore()
    {
        if (GameOverField.GameOver)
        {
            if (score.Player.transform.position.x > MaxScore)
            {
                GameOverField.Max = score.Player.transform.position.x;
                MaxScore = score.Player.transform.position.x;
                MaxScoreText.text = "Max Score:" + MaxScore.ToString() + " m";
            }
        }
        
    }
}

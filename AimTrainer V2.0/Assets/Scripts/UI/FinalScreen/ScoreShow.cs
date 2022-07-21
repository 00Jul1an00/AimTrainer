using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShow : MonoBehaviour
{
    [SerializeField] private TMP_Text _finalScoreText;
    [SerializeField] private TMP_Text _bestScoreText;

    private void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        _finalScoreText.text = $"Score: {score}";
        _bestScoreText.text = $"Best Score: {bestScore}";
    }
}

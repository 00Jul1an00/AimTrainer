using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Raycaster _raycaster;
    [SerializeField] private TMP_Text _scoreText;

    private int _score;
    private static int _bestScore;

    private void OnEnable()
    {
        _raycaster.IncreaseScore += OnScoreIncrease;
    }

    private void OnDisable()
    {
        _raycaster.IncreaseScore -= OnScoreIncrease;

        PlayerPrefs.SetInt("Score", _score);
        PlayerPrefs.SetInt("BestScore", _bestScore);

        if (_bestScore < _score)
        {
            _bestScore = _score;
            PlayerPrefs.SetInt("BestScore", _bestScore);
        }   
    }

    private void OnScoreIncrease()
    {
        _score++;
        _scoreText.text = _score.ToString();
        
    }
}

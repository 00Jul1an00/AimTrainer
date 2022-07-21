using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float _timeInSeconds = 60;
    private TMP_Text _timerText;

    private void Start()
    {
        _timerText = GetComponent<TMP_Text>(); 
    }

    private void Update()
    {
        _timeInSeconds -= Time.deltaTime;
        _timerText.text = $"Timer: {Mathf.Round(_timeInSeconds)}";

        if (_timeInSeconds <= 0)
            SceneManager.LoadScene(3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void Pause()
    {
        Time.timeScale = 0;
        FindObjectOfType<Camera>().GetComponent<Raycaster>().enabled = false;
        _pausePanel.SetActive(true);
    }
}

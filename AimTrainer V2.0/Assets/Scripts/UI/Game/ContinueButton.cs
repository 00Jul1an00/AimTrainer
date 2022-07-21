using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    public void Continue()
    {
        _panel.SetActive(false);
        FindObjectOfType<Camera>().GetComponent<Raycaster>().enabled = true;
        Time.timeScale = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{
    public void GoToSettings()
    {
        SceneManager.LoadScene(1);
    }
}

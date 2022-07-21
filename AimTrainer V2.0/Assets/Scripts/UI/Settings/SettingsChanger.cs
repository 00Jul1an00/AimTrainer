using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SettingsChanger : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _colorDropdown;
    [SerializeField] private TMP_Dropdown _spawnSpeedMultiplierDropdown;
    [SerializeField] private TMP_Dropdown _scalingSpeedMultiplierDropdown;
    [SerializeField] private TMP_Dropdown _scaleMultiplierDropdown;

    public static List<Color> ColorsList = new List<Color>();

    static SettingsChanger()
    {
        ColorsList.Add(Color.red);
        ColorsList.Add(Color.blue);
        ColorsList.Add(Color.yellow);
    }

    private void Start()
    {
        _scaleMultiplierDropdown.value = PlayerPrefs.GetInt("ScaleMultiplierIndex", 3);
        _scalingSpeedMultiplierDropdown.value = PlayerPrefs.GetInt("ScalingSpeedMultiplierIndex", 3);
        _spawnSpeedMultiplierDropdown.value = PlayerPrefs.GetInt("SpawnSpeedMultiplierIndex", 3);
        _colorDropdown.value = PlayerPrefs.GetInt("ChosenColor", 0);
    }

    public void OnUserScaleMultiplier()
    {
        float userScaleMultiplier = Convert.ToSingle(_scaleMultiplierDropdown.captionText.text) * 0.01f;
        PlayerPrefs.SetFloat("ScaleMultiplier", userScaleMultiplier);
        PlayerPrefs.SetInt("ScaleMultiplierIndex", _scaleMultiplierDropdown.value);
    }

    public void OnUserSpawnSpeedMultilpier()
    {
        float userSpawnSpeedMultiplier = Convert.ToSingle(_spawnSpeedMultiplierDropdown.captionText.text) * 0.01f;
        PlayerPrefs.SetFloat("SpawnSpeedMultiplier", userSpawnSpeedMultiplier);
        PlayerPrefs.SetInt("SpawnSpeedMultiplierIndex", _spawnSpeedMultiplierDropdown.value);
    }

    public void OnUserScalingSpeedMultiplier()
    {
        float userSlalingSpeedMultiplier = Convert.ToSingle(_scalingSpeedMultiplierDropdown.captionText.text) * 0.01f;
        PlayerPrefs.SetFloat("ScalingSpeedMultiplier", userSlalingSpeedMultiplier);
        PlayerPrefs.SetInt("ScalingSpeedMultiplierIndex", _scalingSpeedMultiplierDropdown.value);
    }

    public void OnUserColorChose()
    {
        PlayerPrefs.SetInt("ChosenColor", _colorDropdown.value);
    }
}

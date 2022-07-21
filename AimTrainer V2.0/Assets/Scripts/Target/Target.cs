using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    private float _minScale = 1f;
    private float _maxScale = 2.5f;
    private float _scalingSpeed = 0.05f;
    private float _randomScale;
    private bool _isDecrising;
    private SpriteRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();

        if(PlayerPrefs.GetInt("ChosenColor") == SettingsChanger.ColorsList.Count)
        {
            int randomIndex = Random.Range(0, SettingsChanger.ColorsList.Count);
            _renderer.color = SettingsChanger.ColorsList[randomIndex];
        }
        else 
            _renderer.color = SettingsChanger.ColorsList[PlayerPrefs.GetInt("ChosenColor", 0)];


        _randomScale = Random.Range(_minScale, _maxScale);
        transform.localScale = new Vector3(0.01f, 0.01f);
        _scalingSpeed *= PlayerPrefs.GetFloat("ScalingSpeedMultiplier", 1f);
        _randomScale *= PlayerPrefs.GetFloat("ScaleMultiplier", 1f);
    }

    private void FixedUpdate()
    {
        TargetAnimation();
    }

    private void TargetAnimation()
    {
        if (_isDecrising)
            transform.localScale -= new Vector3(_scalingSpeed, _scalingSpeed);
        else
        {
            transform.localScale += new Vector3(_scalingSpeed, _scalingSpeed);

            if (transform.localScale.x >= _randomScale)
                _isDecrising = true;
        }

        if (transform.localScale.x <= 0)
            Destroy(gameObject);
    }

}

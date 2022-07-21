using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _targetPrefab;
    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private Camera _camera;
    
    private float _currentTime = 0f;

    private void Start()
    {
        _timeBetweenSpawn *= PlayerPrefs.GetFloat("SpawnSpeedMultiplier", 1f);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if(_currentTime >= _timeBetweenSpawn)
        {
            SpawnTarget();
            _currentTime = 0;
        }
    }

    private void SpawnTarget()
    {
        Instantiate(_targetPrefab, GetRandomSpawnPosition(), Quaternion.identity, transform);
    }

   
    private Vector2 GetRandomSpawnPosition()
    {
        float xOffset = 2f;
        float yOffset = 2.5f;
        float halfHeight = _camera.orthographicSize;
        float halfWidth = _camera.aspect * halfHeight;
        float horizontalMin = -halfWidth + xOffset;
        float horizontalMax = halfWidth - xOffset;
        float verticalMin = -halfHeight;
        float verticalMax = halfHeight - yOffset;
        float randHorizontal = Random.Range(horizontalMin, horizontalMax);
        float randVertical = Random.Range(verticalMin, verticalMax);
        return new Vector2(randHorizontal, randVertical);
    }
}

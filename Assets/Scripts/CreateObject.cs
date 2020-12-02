using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _timeOfSpawn;
    [SerializeField] private List<Transform> _spawnPoints;
    private  float _elapsedTime;
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _timeOfSpawn)
        {
            _elapsedTime = 0;
            GameObject newGameObject = Instantiate(_template, _spawnPoints[Random.Range(0, _spawnPoints.Count)].position, Quaternion.identity);
        }
    }
}
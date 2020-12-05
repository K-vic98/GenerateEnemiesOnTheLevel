using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObject : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private  float _elapsedTime;
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
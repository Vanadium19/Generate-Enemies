using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{   
    [SerializeField] private EnemyMovement _enemyPrefab;
    [SerializeField] private Vector3[] _spawnPoints = new Vector3[4];
    [SerializeField] private int _directionX;

    private float _delay = 2f;
    //private GameObject _enemy;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    private void OnValidate()
    {
        if (_directionX > 0)
            _directionX = 1;
        else if (_directionX < 0)
            _directionX = -1;
    }

    private IEnumerator Generate()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            EnemyMovement _enemy;

            _enemy = Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)], Quaternion.identity);
            _enemy.SetDestinationX(_directionX);
            yield return wait;
        }
    }
}

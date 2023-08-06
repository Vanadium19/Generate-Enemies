using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{   
    [SerializeField] private EnemyMovement _enemyPrefab;
    [SerializeField] private Vector3[] _spawnPoints = new Vector3[4];
    [SerializeField] private int _directionX;

    private float _delay = 2f;
<<<<<<< HEAD:Assets/Scripts/EnemyGeneration.cs

=======
    
>>>>>>> c4771f41629caa56b03f11b5cf10da26f9f2e618:Assets/Scripts/GenerateEnemy.cs
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
            EnemyMovement enemy;

            enemy = Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)], Quaternion.identity);
            enemy.SetDestinationX(_directionX);
            yield return wait;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _directionX;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _directionX, 0, 0);
    }

    public void SetDestinationX(int directionX)
    {
        _directionX = directionX;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _directionX;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + _directionX, transform.position.y, 0), _speed * Time.deltaTime);        
    }

    public void SetDestinationX(int directionX)
    {
        _directionX = directionX;
    }
}

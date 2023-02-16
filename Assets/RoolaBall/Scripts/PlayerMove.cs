using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Vector3 _direction;


    private const string Horizontal = "Horizontal";
    private const string Vertikal = "Vertical";
    

    private void Update()
    {
        _direction.x = Input.GetAxis(Horizontal);
        _direction.z = Input.GetAxis(Vertikal);
       
        transform.position += _direction * _speed * Time.deltaTime;
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class HPmanager : MonoBehaviour
{
    [SerializeField] private float _maxHelth = 100f;
    [SerializeField] private float _currentHelth;
    [SerializeField] private float _goodBonus;
    [SerializeField] private float _badBonus;

    private Rigidbody _rigidbody;

    public static Action<float> HelthChange;

    private void Awake()
    {
        _currentHelth = _maxHelth;
    }

    private void Start()
    {
        try
        {
            _rigidbody = GetComponent<Rigidbody>();
            _currentHelth += _goodBonus;
            _currentHelth -= _badBonus;
        }

        catch
        {
            Debug.Log("Ошибка");
        }
    }

    private void ReCalculateHP()
    {
        _currentHelth = _currentHelth + _goodBonus - _badBonus;
        HelthChange?.Invoke(_currentHelth);
    }
    public void Hit(float damage)
    {
        _currentHelth -= damage;
       
            
        if (_currentHelth <= 0)
        {
            Time.timeScale = 0;
        }
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    
}

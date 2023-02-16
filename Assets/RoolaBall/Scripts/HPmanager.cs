using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmanager : MonoBehaviour
{
    [SerializeField] private float _maxHelth = 100f;
    [SerializeField] private float _currentHelth;
    [SerializeField] private float _goodBonus;
    [SerializeField] private float _badBonus;

    private void Awake()
    {
        _currentHelth = _maxHelth;
    }

    public void Hit(float damage)
    {
        _currentHelth -= damage;
        _currentHelth += _goodBonus;
        _currentHelth -= _badBonus;
            
        if (_currentHelth <= 0)
        {
            Time.timeScale = 0;
        }
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    
}

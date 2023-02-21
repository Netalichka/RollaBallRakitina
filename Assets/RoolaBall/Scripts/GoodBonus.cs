using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoodBonus : MonoBehaviour
{
    [SerializeField] private float _goodBonus = 10f;

    public void CatchBonus()
    {
        HPmanager.HelthChange += HelthChange;
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
        }
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }

    HPmanager.HelthChange -= HelthChange;
}

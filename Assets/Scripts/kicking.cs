using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kicking : MonoBehaviour
{
    [SerializeField] private Transform ball;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ball")
        {
            if (Input.GetButtonDown("E"))
            { 
                ball.GetComponent<Rigidbody>().AddForce(Vector3.forward);
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class goal : MonoBehaviour
{
    public UnityEvent interact;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            interact.Invoke();
        }
        
    }
}

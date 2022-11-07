using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dribble : MonoBehaviour
{
    [SerializeField] private float offset;

    private Vector3 currentPosition;

    private void OnMouseDown()
    {
        throw new NotImplementedException();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ball")
        {
            currentPosition = transform.position;
            other.transform.position = currentPosition;
        }
    }
}

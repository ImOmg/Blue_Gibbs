using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform playerr;
    [SerializeField] private Transform respawnPoint;
    void OnTriggerEnter(Collider other)
    {
        
        playerr.transform.position = respawnPoint.transform.position;

    }

}

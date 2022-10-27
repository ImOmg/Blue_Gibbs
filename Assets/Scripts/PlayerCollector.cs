using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    [SerializeField] public int Sigil = 0;
    
    [SerializeField] public int Lever = 0;

    //public int SigilLights = 0;
   // public GameObject SigLights;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Sigil"))
        {
            Destroy(col.gameObject);
            Sigil--;
            Debug.Log("sigils " + Sigil);

            if (Sigil <= 0)
            { 
                Destroy(GameObject.FindWithTag("Door"));
            }
            
        }
        
        
        
        if (col.gameObject.CompareTag("lever"))
        {
            Destroy(col.gameObject);
            Lever--;
            Debug.Log("levers " + Lever);

            if (Lever <= 0)
            { 
                Destroy(GameObject.FindWithTag("EDoor"));
            }
            
        }
    }

}

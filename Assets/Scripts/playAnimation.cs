using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{
    [SerializeField] private Animator animationController;

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
        {
            animationController.SetBool("playerNear", true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animationController.SetBool("playerNear", false);
        }

    }
}

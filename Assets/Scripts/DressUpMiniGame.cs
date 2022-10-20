using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DressUpMiniGame : MonoBehaviour
{
    public Transform areaOne;

    private void Update()
    {
        cursorAppears();
    }

    void cursorAppears()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnMouseDown()
    {
        
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;

        this.transform.position = areaOne.position;
      
    }
    
    void OnMouseUp()
    {
        this.transform.parent = null;

        GetComponent<Rigidbody>().useGravity = false;

    }
}

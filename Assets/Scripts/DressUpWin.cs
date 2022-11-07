using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DressUpWin : MonoBehaviour
{
    public GameObject top;
    public GameObject shoes;
    public GameObject pants;

    public bool Top;
    public bool Shoes;
    public bool Pants;

    private DressUpWin[] dressUpArray;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        Top = true;
        Shoes = true;
        Pants = true;

        if (pants == true)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (top && shoes && pants == true)
        {
            if (gameObject.CompareTag("bad"))
            {
                gameObject.SetActive(false);
            }

            if (gameObject.CompareTag("good"))
            {
                gameObject.SetActive(true);
            }
        }

        foreach (DressUpWin DressUp in dressUpArray)
        {
        }
        
    }
    
}

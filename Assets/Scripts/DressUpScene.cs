using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DressUpScene : MonoBehaviour
{
    private void Update()
    {
        reloadScene();
        switchScene();
    }

    void reloadScene()
    {
        bool restart = Input.GetKey(KeyCode.R);

        if (restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void switchScene()
    {
        bool change = Input.GetKey(KeyCode.P);

        if (change)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}

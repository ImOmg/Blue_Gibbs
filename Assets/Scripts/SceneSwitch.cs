using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public GameObject door, player;
    private void Update()
    {
        switchScene();
        reloadScene();
    }

    void switchScene()
    {
        bool change = Input.GetKey(KeyCode.P);

        if (change && Vector3.Distance(player.transform.position, door.transform.position) < 2f)
        {
            SceneManager.LoadScene(1);
        }
    }

    void reloadScene()
    {
        bool restart = Input.GetKey(KeyCode.R);

        if (restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

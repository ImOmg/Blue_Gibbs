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
        bool change = Input.GetKey(KeyCode.N);

        if (change && Vector3.Distance(player.transform.position, door.transform.position) < 7f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

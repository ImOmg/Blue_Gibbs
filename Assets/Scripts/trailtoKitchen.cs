using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailtoKitchen : MonoBehaviour
{
    public GameObject ps1, ps2, ps3, ps4, ps5, player;

    private void Update()
    {
        playerNear();
    }

    void playerNear()
    {
        if(Vector3.Distance(player.transform.position, ps1.transform.position) < 3f)
        {
            ps1.SetActive(false);
            ps2.SetActive(true);
        }

        if (Vector3.Distance(player.transform.position, ps2.transform.position) < 3f)
        {
            ps2.SetActive(false);
            ps3.SetActive(true);
        }

        if (Vector3.Distance(player.transform.position, ps3.transform.position) < 3f)
        {
            ps3.SetActive(false);
            ps4.SetActive(true);
        }

        if (Vector3.Distance(player.transform.position, ps4.transform.position) < 3f)
        {
            ps4.SetActive(false);
            ps5.SetActive(true);
        }
    }
}

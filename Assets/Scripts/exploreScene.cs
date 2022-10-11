using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class exploreScene : MonoBehaviour
{
    public TMP_Text UIText;
    public string downstairsPrompt, findKitchen, playing;
    public GameObject goToKitchen, player;

    private float timer = 0f;

    private void Update()
    {
        explore();
        kitchen();
    }

    void explore()
    {
        timer += Time.deltaTime;

        UIText.text = downstairsPrompt;

        if (timer > 5f)
        {
            UIText.text = playing;
        }
    }

    void kitchen()
    {
        if (Vector3.Distance(player.transform.position, goToKitchen.transform.position) < 3f)
        {
            UIText.text = findKitchen;
        }
    }
}

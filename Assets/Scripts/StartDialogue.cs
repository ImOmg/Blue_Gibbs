using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartDialogue : MonoBehaviour
{
    public GameObject door, player;
    public TMP_Text UIText;
    public string startingDialogue, chooseOutfit, startDressUp, playing;

    private float timer = 0f;

    private void Update()
    {
        startingText();
        nearDoor();
    }

    void startingText()
    {
        timer += Time.deltaTime;

        UIText.text = startingDialogue;

        if(timer > 5f)
        {
            UIText.text = chooseOutfit;
        }

        if(timer > 10f)
        {
            UIText.text = playing;
        }
    }

    void nearDoor()
    {
        if (Vector3.Distance(player.transform.position, door.transform.position) < 4f)
        {
            UIText.text = startDressUp;
        }
    }
}

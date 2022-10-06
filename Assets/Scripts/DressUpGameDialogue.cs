using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DressUpGameDialogue : MonoBehaviour
{
    public TMP_Text UIText;
    public string gameInstructions, gamePrompt;

    private float timer = 0f;

    private void Update()
    {
        gamePromt();
    }

    void gamePromt()
    {
        timer += Time.deltaTime;
        UIText.text = gameInstructions;

        if (timer > 3f)
        {
            UIText.text = gamePrompt;
        }
    }

    
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DressUpGameDialogue : MonoBehaviour
{
    public TMP_Text UIText, UIText2;
    
    public GameObject goodD;
    public GameObject BadD;

    public string gameInstructions,
        gamePrompt,
        goodTop,
        badTop,
        goodBottoms,
        badBottoms,
        goodShoes,
        badShoes,
        outfitChosen,
        playing;

    public Transform areaTop, areaBottoms, areaShoes;

    public GameObject top,
        jersey,
        shoes,
        runners,
        shorts,
        skirt,
        suitTop,
        suitPants,
        suitShoes,
        heels,
        dress,
        camera1,
        camera2;

    private float timer = 0f;

    private void Update()
    {
        gamePromt();
        itemsChosen(); 
        // chosenItemDialogue();
    }

    void gamePromt()
    {
        timer += Time.deltaTime;
        UIText.text = gameInstructions;

        if (timer > 3f)
        {
            UIText.text = playing;
            // UIText2.text = gamePrompt;
        }
    }


    void itemsChosen()
    {
        bool topChosen = Vector3.Distance(top.transform.position, areaTop.transform.position) < 1f;
        bool jerseyChosen = Vector3.Distance(jersey.transform.position, areaTop.transform.position) < 1f;
        bool runnersChosen = Vector3.Distance(runners.transform.position, areaShoes.transform.position) < 2f;
        bool shoesChosen = Vector3.Distance(shoes.transform.position, areaShoes.transform.position) < 2f;
        bool shortsChosen = Vector3.Distance(shorts.transform.position, areaBottoms.transform.position) < 2f;
        bool skirtChosen = Vector3.Distance(skirt.transform.position, areaBottoms.transform.position) < 2f;
        bool dressChosen = Vector3.Distance(dress.transform.position, areaBottoms.transform.position) < 2f;
        bool suitTopChosen = Vector3.Distance(suitTop.transform.position, areaBottoms.transform.position) < 2f;
        bool suitPantsChosen = Vector3.Distance(suitPants.transform.position, areaBottoms.transform.position) < 2f;
        bool suitShoesChosen = Vector3.Distance(suitShoes.transform.position, areaBottoms.transform.position) < 2f;
        bool heelsChosen = Vector3.Distance(heels.transform.position, areaBottoms.transform.position) < 2f;

        if (topChosen)
        {
            jersey.SetActive(false);
            //    dress.SetActive(false);
            //   suitTop.SetActive(false);
        }

        if (jerseyChosen)
        {
            top.SetActive(false);
            //   dress.SetActive(false);
            //  suitTop.SetActive(false);
        }

        /*
        if (dressChosen)
        {
            top.SetActive(false);
            jersey.SetActive(false);
            suitTop.SetActive(false);
            shorts.SetActive(false);
            skirt.SetActive(false);
            suitPants.SetActive(false);
        }
        */

        /*
        if (suitTopChosen)
        {
            top.SetActive(false);
            dress.SetActive(false);
            jersey.SetActive(false);
        }
        */

        if (shoesChosen)
        {
            runners.SetActive(false);
            //  heels.SetActive(false);
            //   suitShoes.SetActive(false);
        }

        if (runnersChosen)
        {
            shoes.SetActive(false);
            //  heels.SetActive(false);
            //  suitShoes.SetActive(false);
        }

        if (heelsChosen)
        {
            shoes.SetActive(false);
            //  suitShoes.SetActive(false);
            runners.SetActive(false);
        }

        /*
        if (suitShoesChosen)
        {
            shoes.SetActive(false);
            heels.SetActive(false);
            runners.SetActive(false);
        }
        */

        if (shortsChosen)
        {
            skirt.SetActive(false);
            //  dress.SetActive(false);
            // suitPants.SetActive(false);
        }

        if (skirtChosen)
        {
            shorts.SetActive(false);
            //  dress.SetActive(false);
            // suitPants.SetActive(false);
        }

        /*
        if (suitPantsChosen)
        {
            shorts.SetActive(false);
            skirt.SetActive(false);
            dress.SetActive(false);
        }
        */

        bool topDone =
            jersey.activeInHierarchy == false ||
            top.activeInHierarchy ==
            false; // || dress.activeInHierarchy == false || suitTop.activeInHierarchy == false;
        bool shoesDone =
            runners.activeInHierarchy == false ||
            shoes.activeInHierarchy ==
            false; // || heels.activeInHierarchy == false || suitShoes.activeInHierarchy == false;
        bool bottomsDone =
            shorts.activeInHierarchy == false ||
            skirt.activeInHierarchy ==
            false; // || dress.activeInHierarchy == false || suitPants.activeInHierarchy == false;

        if (topDone && shoesDone && bottomsDone)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            UIText2.text = outfitChosen;
        }
    }

    void chosenItemDialogue()
    {
        bool topChosen = Vector3.Distance(top.transform.position, areaTop.transform.position) < 1f;
        bool jerseyChosen = Vector3.Distance(jersey.transform.position, areaTop.transform.position) < 1f;
        bool runnersChosen = Vector3.Distance(runners.transform.position, areaShoes.transform.position) < 2f;
        bool shoesChosen = Vector3.Distance(shoes.transform.position, areaShoes.transform.position) < 2f;
        bool shortsChosen = Vector3.Distance(shorts.transform.position, areaBottoms.transform.position) < 2f;
        bool skirtChosen = Vector3.Distance(skirt.transform.position, areaBottoms.transform.position) < 2f;

        /*
        bool dressChosen = Vector3.Distance(dress.transform.position, areaBottoms.transform.position) < 2f;
        bool suitTopChosen = Vector3.Distance(suitTop.transform.position, areaBottoms.transform.position) < 2f;
        bool suitPantsChosen = Vector3.Distance(suitPants.transform.position, areaBottoms.transform.position) < 2f;
        bool suitShoesChosen = Vector3.Distance(suitShoes.transform.position, areaBottoms.transform.position) < 2f;
        bool heelsChosen = Vector3.Distance(heels.transform.position, areaBottoms.transform.position) < 2f;
        */
        
        /*
        if (skirtChosen && topChosen && shoesChosen == true)
        {
              goodD.SetActive(true);
              BadD.SetActive(false);
              Console.WriteLine("good");
        }
        else
        {
              BadD.SetActive(true);
              goodD.SetActive(false);
              Console.WriteLine("bad");
        }*/

        if (topChosen)
        {
            UIText.text = goodTop;
        }

        if (jerseyChosen)
        {
            UIText.text = badTop;
        }

        if (runnersChosen)
        {
            UIText.text = badShoes;
        }

        if (shoesChosen)
        {
            UIText.text = goodShoes;
        }

        if (shortsChosen)
        {
            UIText.text = badBottoms;
        }

        if (skirtChosen)
        {
            UIText.text = goodBottoms;
        }
        
        
        

    }
    
}
    

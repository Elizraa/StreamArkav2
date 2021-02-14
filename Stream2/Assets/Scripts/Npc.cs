using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    public GameObject panelFisherman, panelKids;

    [TextArea(3,5)]
    public string[] fishermanText, kidsText;
    public Text textFishermanUI, textKidsUI;

    int textNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fishermanTalk()
    {
        textFishermanUI.text = fishermanText[0];
        textNumber = 0;
        panelFisherman.SetActive(true);
    }

    public void nextFishermanTalk()
    {
        if(textNumber+1 == fishermanText.Length)
        {
            panelFisherman.SetActive(false);
            textNumber = 0;
            return;
        }
        textFishermanUI.text = fishermanText[++textNumber];
    }   
    
    public void kidsTalk()
    {
        textKidsUI.text = kidsText[0];
        panelKids.SetActive(true);
    }

    public void nextKidsTalk()
    {
        if(textNumber+1 == kidsText.Length)
        {
            panelKids.SetActive(false);
            textNumber = 0;
            return;
        }
        textKidsUI.text = kidsText[++textNumber];
    }
}

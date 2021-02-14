using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToMainGame()
    {
        LevelLoader.levelLoader.changeScene(1);
    }

    public void goToMiniGame()
    {
        LevelLoader.levelLoader.changeScene(2);
    }

}

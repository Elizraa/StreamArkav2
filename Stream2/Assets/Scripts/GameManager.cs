using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public Transform mainCamera,player;
    public Transform[] levelSpawner;
    public GameObject[] levelPrefab;

    public Transform[] playerSpawn;
    [HideInInspector]
    public GameObject currentLevel;
    [HideInInspector]
    public int levelIndex;
    public bool playerHide;

    public AudioSource cameraAudio;
    public AudioClip intenseMusic, sans, busted;

    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
            gameManager = this;
        Instantiate(levelPrefab[0], levelSpawner[0].position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GameOver()
    {
        Destroy(currentLevel);
        currentLevel = Instantiate(levelPrefab[levelIndex],levelSpawner[levelIndex].position,Quaternion.identity);
        player.position = playerSpawn[levelIndex - 1].position;
        playerHide = false;
        Time.timeScale = 1f;
    }

    public void HomeButton()
    {
        LevelLoader.levelLoader.changeScene(0);
    }
}

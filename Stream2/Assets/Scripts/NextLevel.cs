using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.parent.name == "Level1(Clone)")
        {
            GameManager.gameManager.currentLevel = Instantiate(GameManager.gameManager.levelPrefab[1], GameManager.gameManager.levelSpawner[1].position, Quaternion.identity);
            GameManager.gameManager.mainCamera.position = new Vector3(GameManager.gameManager.levelSpawner[1].position.x,GameManager.gameManager.levelSpawner[1].position.y, GameManager.gameManager.mainCamera.position.z);
            GameManager.gameManager.levelIndex = 1;
            GameManager.gameManager.cameraAudio.clip = GameManager.gameManager.intenseMusic;
            GameManager.gameManager.cameraAudio.volume = 0.1f;
            GameManager.gameManager.cameraAudio.Play();
            Destroy(transform.parent.gameObject);
        }
        else if (transform.parent.name == "Level2(Clone)")
        {
            GameManager.gameManager.currentLevel = Instantiate(GameManager.gameManager.levelPrefab[2], GameManager.gameManager.levelSpawner[2].position, Quaternion.identity);
            GameManager.gameManager.mainCamera.position = new Vector3(GameManager.gameManager.levelSpawner[2].position.x, GameManager.gameManager.levelSpawner[2].position.y, GameManager.gameManager.mainCamera.position.z);
            GameManager.gameManager.levelIndex = 2;
            Destroy(transform.parent.gameObject);
        }
        else if (transform.parent.name == "Level3(Clone)")
        {
            GameManager.gameManager.currentLevel = Instantiate(GameManager.gameManager.levelPrefab[3], GameManager.gameManager.levelSpawner[3].position, Quaternion.identity);
            GameManager.gameManager.mainCamera.position = new Vector3(GameManager.gameManager.levelSpawner[3].position.x, GameManager.gameManager.levelSpawner[3].position.y, GameManager.gameManager.mainCamera.position.z);
            GameManager.gameManager.levelIndex = 3;
            Destroy(transform.parent.gameObject);
        }
        else if (transform.parent.name == "Level4(Clone)")
        {
            GameManager.gameManager.currentLevel = Instantiate(GameManager.gameManager.levelPrefab[4], GameManager.gameManager.levelSpawner[4].position, Quaternion.identity);
            GameManager.gameManager.mainCamera.position = new Vector3(GameManager.gameManager.levelSpawner[4].position.x, GameManager.gameManager.levelSpawner[4].position.y, GameManager.gameManager.mainCamera.position.z);
            GameManager.gameManager.levelIndex = 4;
            GameManager.gameManager.cameraAudio.clip = GameManager.gameManager.sans;
            GameManager.gameManager.cameraAudio.Play();
            GameManager.gameManager.cameraAudio.volume = 0.5f;
            Destroy(transform.parent.gameObject);
        }
    }
}
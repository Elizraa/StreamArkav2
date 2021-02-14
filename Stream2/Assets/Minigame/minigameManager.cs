using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigameManager : MonoBehaviour
{
    public static minigameManager minigame;

    public int maxSampah;
    [HideInInspector]
    public int sampahDitangan;
    public Text textSampah, textScore, finalScore;
    public Image Bg;

    public GameObject wall, panelTutor, panelGameOver;
    public GameObject[] heart;
    public Transform player;

    [SerializeField]
    private int health;
    private int score, scoreInHand;
    [HideInInspector]
    public int blocked = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (minigame == null)
            minigame = this;
        textSampah.text = sampahDitangan + " / " + maxSampah;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sampahPick(GameObject sampah, int value)
    {
        if (sampahDitangan == maxSampah)
        {
            Bg.color = Color.red;
            return;
        }
        sampahDitangan++;
        textSampah.text = sampahDitangan + " / " + maxSampah;
        scoreInHand += value;
        Destroy(sampah);
    }

    public void sampahThrow()
    {
        score += scoreInHand;
        textScore.text = "Score : " + score;
        scoreInHand = 0;

        if (score >= 60 && maxSampah == 6) maxSampah--;
        else if (score >= 120 && blocked == 0) activeWall();
        if (score >= 200 && maxSampah == 5) maxSampah--;

        Bg.color = Color.white;
        sampahDitangan = 0;
        textSampah.text = sampahDitangan + " / " + maxSampah;
    }

    void activeWall()
    {
        if (player.position.y==-4)
        {
            blocked = 1;
            wall.transform.position = new Vector2(3.4f, 3f);
        }
        else
        {
            blocked = 2;
            wall.transform.position = new Vector2(3.4f, -3f);
        }
            wall.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(heart[--health]);
        if (health == 0) gameOver();
    }

    void gameOver()
    {
        finalScore.text = "Final Score\n" + score;
        panelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void startGame()
    {
        panelTutor.SetActive(false);
        Time.timeScale = 1f;
    }

    public void home()
    {
        LevelLoader.levelLoader.changeScene(0);
    }
    public void retry()
    {
        LevelLoader.levelLoader.changeScene(2);
    }
}

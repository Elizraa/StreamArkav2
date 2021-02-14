using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator bustedAnim;
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
        if (collision.gameObject.CompareTag("Player") && !GameManager.gameManager.playerHide)
        {
            Time.timeScale = 0f;
            StartCoroutine(busted());
        }
    }

    IEnumerator busted()
    {
        yield return new WaitForSecondsRealtime(3f);
        GameManager.gameManager.GameOver();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (GameManager.gameManager.playerHide) return;
#pragma warning disable CS0642 // Possible mistaken empty statement
        if (collision.gameObject.CompareTag("Player") && Time.timeScale != 0) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Time.timeScale = 0f;
            StartCoroutine(busted());
            //Debug.Log(GameManager.gameManager.playerHide);
        }
    }
}

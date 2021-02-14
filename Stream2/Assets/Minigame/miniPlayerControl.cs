using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miniPlayerControl : MonoBehaviour
{
    public int scrollSpeed;
    int i = 0;
    int j = 0;

    public Button bin1,bin2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            i++;
            if (i == scrollSpeed)
            {
                i = 0;
                moveUp();
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if(++j == scrollSpeed)
            {
                j = 0;
                moveDown();
            }
        }
    }

    void moveUp()
    {
        if (transform.position.y == 4) return;
        if (transform.position.y == 2)
        {
            if (minigameManager.minigame.blocked == 1) return;
            transform.position = new Vector2(transform.position.x, transform.position.y + 2f);
            bin1.interactable = true;
            return;
        }
        if (transform.position.y == -4)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 2f);
            bin2.interactable = false;
            return;
        }
        transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
    }

    void moveDown()
    {
        if (transform.position.y == -4) return;
        if (transform.position.y == 4)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 2f);
            bin1.interactable = false;
            return;
        }
        if (transform.position.y == -2)
        {
            if (minigameManager.minigame.blocked == 2) return;
            transform.position = new Vector2(transform.position.x, transform.position.y - 2f);
            bin2.interactable = true;
            return;
        }
        transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        if (go.CompareTag("Sampah"))
        {
            go.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        if (go.CompareTag("Sampah"))
        {
            go.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = false;
        }
    }
}

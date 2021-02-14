using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miniSampah : MonoBehaviour
{
    public float minSpeed, maxSpeed;
    public int value;
    public Button someButton;
    float speed;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        rb.velocity = transform.right * speed;
    }
    void OnEnable()
    {
        //Register Button Events
        someButton.onClick.AddListener(() => minigameManager.minigame.sampahPick(this.gameObject, value));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    //public Transform playerGraf;

    public Animator anim;
    Vector2 movement;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Time.timeScale != 0f)
        {
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Vertical", movement.y);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //if (movement != Vector2.zero) anim.SetBool("Run", true);
        //else anim.SetBool("Run", false);

        //if (movement.y > 0.01f) transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        //else if (movement.y < -0.01f) transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 180f));
        //else if (movement.x > 0.01f) transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -90f));
        //else if (movement.x < -0.01f) transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 90f));

    }
}

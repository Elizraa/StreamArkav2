using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonNPCTrigger : MonoBehaviour
{
    public GameObject buttonDialoge, boxChat;

    // Start is called before the first frame update
    void Start()
    {
        buttonDialoge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        buttonDialoge.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        buttonDialoge.SetActive(false);
        boxChat.SetActive(false);
    }
}

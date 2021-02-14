using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniSampahClicked : MonoBehaviour
{

    public Color colorHover;
    public SpriteRenderer sprite;
    Color prevColor;
    // Start is called before the first frame update
    void Start()
    {
        prevColor = sprite.color;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseOver()
    {
        if (!this.enabled) return;
        sprite.color = colorHover;
    }

    void OnMouseExit()
    {
        if (!this.enabled) return;
        sprite.color = prevColor;
    }

    private void OnDisable()
    {
        sprite.color = prevColor;
    }
}

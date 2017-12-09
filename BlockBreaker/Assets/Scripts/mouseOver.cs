using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOver : MonoBehaviour {

    public Sprite sprite1; // original sprite
    public Sprite sprite2; // new sprite
    private SpriteRenderer sR;

    // Use this for initialization
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        if (sR.sprite == null) sR.sprite = sprite1;
    }

    // Use this for initialization
    public void PointerEnter() {
        sR.sprite = sprite2;
    }

    // Update is called once per frame
    public void PointerExit() {
        sR.sprite = sprite1;
    }

    public void ClickExit()
    {
        print("i'm here in clickexit");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2deck : MonoBehaviour
{
    public player2 p2dc;
    public Sprite no_image;
    public Sprite Back;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Back;
    }

    // Update is called once per frame
    public void draw2()
    {
        if (p2dc.cards_in_deck2 == 0){
            this.gameObject.GetComponent<SpriteRenderer>().sprite =no_image;
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Back;
        }
    }
}

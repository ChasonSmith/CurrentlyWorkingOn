using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1deck : MonoBehaviour
{
    public player1 p1dc;
    public Sprite no_image;
    public Sprite Back;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Back;
    }

    // Update is called once per frame
    public void draw1()
    {
        if (p1dc.cards_in_deck1 == 0){
            this.gameObject.GetComponent<SpriteRenderer>().sprite =no_image;
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Back;
        }
    }
}

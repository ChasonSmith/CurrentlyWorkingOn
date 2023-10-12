using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class p2discard : MonoBehaviour
{
    public bool isEmpty;
    public Sprite Front;
    public Sprite Back;
    public Sprite no_image;
    public player2 p2d;
    // Start is called before the first frame update
    void Start()
    {
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = no_image;
    }

    // Update is called once per frame
    public void update_discard2(){
        if (p2d.cards_in_deck2 != p2d.starting_cards2){
            Front = p2d.p2discard.Last();
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().sprite = no_image;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class p1discard : MonoBehaviour
{
    public bool isEmpty;
    public Sprite Front;
    public Sprite Back;
    public Sprite no_image;
    public player1 p1d;
    // Start is called before the first frame update
    void Start()
    {
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = no_image;
    }

    // Update is called once per frame
    public void update_discard1(){
        if (p1d.cards_in_deck1 != p1d.starting_cards1){
            Front = p1d.p1discard.Last();
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().sprite = no_image;
        }
    }
}

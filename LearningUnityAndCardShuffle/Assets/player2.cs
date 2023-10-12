using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player2 : MonoBehaviour
{
    public List<Sprite> p2discard = new List<Sprite>();
    public List<Sprite> p2hand = new List<Sprite>();
    public Sprite no_image;
    public bool isEmpty;
    public Sprite Front;
    public Sprite Back;
    public int count;
    public int cards_in_deck2;
    public int cards_in_discard;
    public int r;
    public int starting_cards2;
    public GameManager p2;

    // Start is called before the first frame update
    void Start()
    {
        
        count = 0;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = no_image;
        //cards_in_deck2 = p2.p2d.Count;
        cards_in_deck2 = 7;
        starting_cards2 = cards_in_deck2;
    }

    // Update is called once per frame
    public void On_Click(){
        if (cards_in_deck2 == starting_cards2){
            Front = p2.p2d[0];
            p2hand.Add(Front);
            p2.p2d.Remove(Front);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
            cards_in_deck2--;
            isEmpty = false;
        }
        else if(cards_in_deck2 > 0){
            Front = p2.p2d[0];
            p2hand.Add(Front);
            p2discard.Add(p2hand[0]);
            p2hand.Remove(p2hand[0]);
            p2.p2d.Remove(Front);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
            cards_in_deck2--;
        }
        else if (isEmpty == true){
            cards_in_discard = p2discard.Count;
            while(cards_in_discard > 0){
                r = Random.Range(0, cards_in_discard);
                p2.p2d.Add(p2discard[r]);
                p2discard.Remove(p2discard[r]);
                cards_in_discard--;
                cards_in_deck2++;
            }
        }
        else{
            isEmpty = true;
            Front = no_image;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
            p2discard.Add(p2hand[0]);
            p2hand.Remove(p2hand[0]);
        }
        
    }     
}

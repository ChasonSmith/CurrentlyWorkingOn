using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player1 : MonoBehaviour
{
    public List<Sprite> p1discard = new List<Sprite>();
    public List<Sprite> p1hand = new List<Sprite>();
    public Sprite no_image;
    public bool isEmpty;
    public Sprite Front;
    public Sprite Back;
    public int count;
    public int cards_in_deck1;
    public int cards_in_discard;
    public int r;
    public int starting_cards1;
    public GameManager p1;

    // Start is called before the first frame update
    void Start()
    {
        
        count = 0;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = no_image;
        cards_in_deck1 = p1.p1d.Count;
        starting_cards1 = cards_in_deck1;
    }

    // Update is called once per frame
    public void On_Click(){
        if (cards_in_deck1 == starting_cards1){
            Front = p1.p1d[0];
            p1hand.Add(Front);
            p1.p1d.Remove(Front);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
            cards_in_deck1--;
            isEmpty = false;
        }
        else if(cards_in_deck1 > 0){
            Front = p1.p1d[0];
            p1hand.Add(Front);
            p1discard.Add(p1hand[0]);
            p1hand.Remove(p1hand[0]);
            p1.p1d.Remove(Front);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
            cards_in_deck1--;
        }
        else if (isEmpty == true){
            cards_in_discard = p1discard.Count;
            while(cards_in_discard > 0){
                r = Random.Range(0, cards_in_discard);
                p1.p1d.Add(p1discard[r]);
                p1discard.Remove(p1discard[r]);
                cards_in_discard--;
                cards_in_deck1++;
            }
        }
        else{
            isEmpty = true;
            Front = no_image;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
            p1discard.Add(p1hand[0]);
            p1hand.Remove(p1hand[0]);
        }
        
    }     
}

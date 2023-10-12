using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// GameManager.cs
public class GameManager : MonoBehaviour {
    public List<Sprite> p1d = new List<Sprite>();
    public List<Sprite> p2d = new List<Sprite>();
    public Sprite Luke;
    public Sprite Anakin;
    public Sprite Vader;
    public Sprite Han;
    public Sprite Leia;
    public Sprite Kylo;
    public Sprite Padme;
    public Sprite Grevious;
    public Sprite Dooku;
    public Sprite Yoda;
    public Sprite Palps;
    public Sprite Obi;
    public Sprite Mace;
    public Sprite Qui;
    public Sprite Maul;
    public int count2;
    public int ra;
    public int cards_to_deal = 15;
    public List<Sprite> all_cards = new List<Sprite>();
    private void Start() {
        all_cards.Add(Luke);
        all_cards.Add(Anakin);
        all_cards.Add(Vader);
        all_cards.Add(Han);
        all_cards.Add(Leia);
        all_cards.Add(Kylo);
        all_cards.Add(Padme);
        all_cards.Add(Grevious);
        all_cards.Add(Dooku);
        all_cards.Add(Yoda);
        all_cards.Add(Palps);
        all_cards.Add(Obi);
        all_cards.Add(Mace);
        all_cards.Add(Qui);
        all_cards.Add(Maul);
        while(cards_to_deal > 0){
            ra = Random.Range(0, cards_to_deal);
            if(cards_to_deal % 2 == 1){
                p1d.Add(all_cards[ra]);
                all_cards.Remove(all_cards[ra]);
            }
            else{
                p2d.Add(all_cards[ra]);
                all_cards.Remove(all_cards[ra]);
            }
            cards_to_deal--;
        }
    }
    
}

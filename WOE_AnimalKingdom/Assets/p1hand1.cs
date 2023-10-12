using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class p1hand1 : MonoBehaviour
{
    public CardMaker p1;
    public Card p1card;
    public Sprite noCard;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(p1.p1Hand.Count >= 1){
            p1card = p1.p1Hand[0];
            this.gameObject.GetComponent<SpriteRenderer>().sprite = p1card.image;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = noCard;
        }
    }
}

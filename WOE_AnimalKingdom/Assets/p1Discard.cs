using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class p1Discard : MonoBehaviour
{
    public Sprite noCard;
    public CardMaker p1;
    public int discardLength;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = noCard;
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.p1Discard.Count != 0)
        {
            int discardLength = p1.p1Discard.Count;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = p1.p1Discard[discardLength-1].image;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = noCard;
        }
    }
}

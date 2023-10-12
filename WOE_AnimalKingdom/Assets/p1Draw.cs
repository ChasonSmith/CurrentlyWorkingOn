using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class p1Draw : MonoBehaviour
{
    public Sprite cardBack;
    public Sprite noCard;
    public CardMaker p1;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = cardBack;
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.p1Deck.Count != 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = cardBack;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = noCard;
        }
    }
}

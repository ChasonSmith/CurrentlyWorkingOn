using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickP1H7 : MonoBehaviour
{
    public CardMaker card7;
    public int numClicks;

 
    

    void Start()
    {
        numClicks = 0;
       
    }
    void OnMouseDown()
    {
        numClicks++;
    }
    void Update()
    {
        if(numClicks % 2 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
            card7.p1Hand[6] = new Card(card7.p1Hand[6].points, card7.p1Hand[6].image, true, card7.p1Hand[6].cardPlayed);
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
             card7.p1Hand[6] = new Card(card7.p1Hand[6].points, card7.p1Hand[6].image, false, card7.p1Hand[6].cardPlayed);
        }
    }
}



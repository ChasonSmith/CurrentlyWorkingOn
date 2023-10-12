using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickP1H6 : MonoBehaviour
{
    public CardMaker card6;
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
            card6.p1Hand[5].cardToPlay = true;
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
             card6.p1Hand[5].cardToPlay = false;
        }
    }
}


